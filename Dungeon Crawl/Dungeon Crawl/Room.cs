using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Dungeon_Crawl;

namespace DungeonCrawl
{
    public class Room
    {
        private bool player = false;//true if player is in the room
        private bool enemy = false;
        private List<Item> items = new List<Item>();
        private List<MobileObject> enemies = new List<MobileObject>();
        private bool doorLocked = false;
        private Ally ally1;
        private Ally ally2;
        private Player play;
        private Lever lever;
        private bool hasLever = false;
        private bool exit = false;
        private bool openExit = false;

        public Player playerObject
        {
            get { return play; }
            set { play = value; }
        }
        public bool Enemy
        {
            get
            {
                return enemy;
            }

            set
            {
                enemy = value;
            }
        }

        public bool Player
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

        public bool HasLever
        {
            get
            {
                return hasLever;
            }

            set
            {
                hasLever = value;
                lever = new Lever();
            }
        }

        internal Lever Lever
        {
            get
            {
                return lever;
            }

            set
            {
                lever = value;
            }
        }

        public bool Exit
        {
            get
            {
                return exit;
            }

            set
            {
                exit = value;
            }
        }

        public bool OpenExit
        {
            get
            {
                return openExit;
            }

            set
            {
                openExit = value;
            }
        }

        public Ally Ally2
        {
            get
            {
                return ally2;
            }

            set
            {
                ally2 = value;
            }
        }

        public Ally Ally1
        {
            get
            {
                return ally1;
            }

            set
            {
                ally1 = value;
            }
        }

        internal List<Item> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }

        public Room()//empty Room
        {
            
        }
        public void addItem(Item i)
        {
            items.Add(i);
        }
        public void playerEnter()
        {
            Player = true;
        }
        public void playerExit()
        {
            Player = false;
        }
        public void enemyEnter(MobileObject e)
        {
            Enemies.Add(e);
            Enemy = true;
        }
        public void enemyExit(MobileObject e)
        {
            Enemies.Remove(e);
            if (Enemies.FirstOrDefault() == null)
            {
                Enemy = false;
            }
        }
        public bool isDoorLocked()
        {
            return doorLocked;
        }
        
        
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            
            return str.ToString();
        }
    }
}
