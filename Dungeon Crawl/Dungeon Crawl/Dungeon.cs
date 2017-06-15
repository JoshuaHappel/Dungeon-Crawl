using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.MOBs;
using DungeonCrawl.MOBs.Enemies;
using DungeonCrawl.UnitClasses;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using Dungeon_Crawl;

namespace DungeonCrawl
{
    enum Directions  {NORTH, SOUTH, EAST, WEST };
    public class Dungeon
    {
        private Random rand1 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        private List<MobileObject> enemies = new List<MobileObject>();//list to hold the enemies in a dungeon floor
        private Room[,] dungeon = new Room[5, 5];//two dimensional array to hold rooms and serve as map each index is a room
        private int numberOfEnemies;
        private bool exitUnlocked = false;
        private int exitXCoor;
        private int exitYCoor;
        private Player player;
        private static int floor = 0;
        internal Player Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }
        internal List<MobileObject> Enemies
        {
            get
            {
                return enemies;
            }

            set
            {
                enemies = value;
            }
        }
        public static int Floor
        {
            get
            {
                return floor;
            }

            set
            {
                floor = value;
            }
        }
        public Dungeon(Player p)
        {
            player = p;
            Ally ally1 = new Ally("Taako", 25, 6, 1, 4, new Mage());
            Ally ally2 = new Ally("Magnus", 50, 1, 7, 3, new Fighter());
            ally1.ColumnLoc = rand1.Next(5);
            ally1.RowLoc = rand1.Next(5);
            ally2.ColumnLoc = rand1.Next(5);
            ally2.RowLoc = rand1.Next(5);

            createMap();

            dungeon[ally1.ColumnLoc, ally1.RowLoc].Ally1 = ally1;
            dungeon[ally2.ColumnLoc, ally2.RowLoc].Ally2 = ally2;
        }
        public void createMap()
        {

            /*this for loop populates the array starting at 0,0 it populates by columns going top down
             * the int variable column determines the current column to populate and int i is the row
             * these are empty rooms
             * when i is equal to 3 (when it finishes a column) and if column is less than 4 the for loop resets and populates the next column
             */
             for (int c = 0; c < 5; c++)
            {
                for (int r = 0; r < 5; r++)
                {
                    dungeon[c, r] = new Room();
                }
            }
            int numberOfItems = 50 + rand1.Next(26);//puts minimum items at 50 plus a random number between 0-25
            for (int i = 0; i < 4; i++)
            {
                dungeon[rand1.Next(5), rand1.Next(5)].HasLever = true;//adds the levers to the room
            }
            exitYCoor = rand1.Next(5);//puts the exit somewhere
            exitXCoor = rand1.Next(5);
            dungeon[exitXCoor, exitYCoor].Exit = true;
            int numberOfDifferentItems = SQL_DAO.getItemDBLength();
            for (int i = 0; i < numberOfItems; i++)
            {
                int item = rand1.Next(numberOfDifferentItems);
                item++;
                dungeon[rand1.Next(5), rand1.Next(5)].Items.Add(SQL_DAO.getItemInfoFromDB(item));
            }
            numberOfEnemies = rand1.Next(4) + 1 + Floor;
            int enemytype = rand1.Next(11);
            for (int i = 0; i < numberOfEnemies; i++)
            {
                if (enemytype <= 3)
                {
                    Wraith w = new Wraith();
                    w.RowLoc = rand1.Next(4) + 1;
                    w.ColumnLoc = rand1.Next(4) + 1;
                    Enemies.Add(w);
                }
                else if (enemytype <= 5)
                {
                    Goblin g = new Goblin();
                    g.RowLoc = rand1.Next(4) + 1;
                    g.ColumnLoc = rand1.Next(4) + 1;
                    Enemies.Add(g);
                }
                else if (enemytype <= 7)
                {
                    Sorcerer s = new Sorcerer();
                    s.RowLoc = rand1.Next(4) + 1;
                    s.ColumnLoc = rand1.Next(4) + 1;
                    Enemies.Add(s);
                }
                else if (enemytype <= 9)
                {
                    Orc o = new Orc();
                    o.ColumnLoc = rand1.Next(4) + 1;
                    o.RowLoc = rand1.Next(4) + 1;
                    Enemies.Add(o);
                }
                else if (enemytype <= 10)
                {
                    Uruk_Hai u = new Uruk_Hai();
                    u.RowLoc = rand1.Next(4) + 1;
                    u.ColumnLoc = rand1.Next(4) + 1;
                }
            }
            
        }
        public void unlockExit()
        {
            exitUnlocked = true;
            dungeon[exitXCoor, exitYCoor].OpenExit = true;
        }
        public void movePlayer(int oldXCoor, int oldYCoor, int newXCoor, int newYCoor)
        {
            if (newXCoor > 4)
                newXCoor = 4;
            if (newYCoor > 4)
                newYCoor = 4;
            if (newXCoor < 0)
                newXCoor = 0;
            if (newYCoor < 0)
                newYCoor = 0;
            dungeon[oldYCoor, oldXCoor].playerExit();
            dungeon[newYCoor, newXCoor].playerEnter();
        }
        public void moveEnemy( int oldXCoor, int oldYCoor, int newXCoor, int newYCoor, MobileObject m)
        {
            if (newXCoor > 4)
                newXCoor = 4;
            if (newYCoor > 4)
                newYCoor = 4;
            if (newXCoor < 0)
                newXCoor = 0;
            if (newYCoor < 0)
                newYCoor = 0;
            dungeon[oldYCoor, oldXCoor].enemyExit(m);
            dungeon[newYCoor, newXCoor].enemyEnter(m);
        }
        public Room getCurrentRoom(int x, int y)
        {
            return dungeon[x, y];
        }
    }
}
