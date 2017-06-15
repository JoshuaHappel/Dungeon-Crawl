using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DungeonCrawl.UnitClasses;
using DungeonCrawl.MOBs.Enemies;
using System.Data.OleDb;
using Dungeon_Crawl;

namespace DungeonCrawl
{
    public class Player : MobileObject
    {
        private List<Item> items = new List<Item>();
        private List<Ally> party = new List<Ally>();
        private bool madeNoise = false;
        public bool MadeNoise
        {
            get
            {
                return madeNoise;
            }

            set
            {
                madeNoise = value;
            }
        }

        internal List<Ally> Party
        {
            get
            {
                return party;
            }

            set
            {
                party = value;
            }
        }

        public List<Item> Items
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

        public Player(int hp, int strength, int armor, int dam, int speed)
        {
            HP = hp;
            ArmorClass = armor;
            Strength = strength;
            CanAttack = true;
            Speed = speed;
        }
        public Player()
        {
            Name = "Player";
            HP = 100;
            Strength = 10;
            MagicPower = 10;
            Speed = 10;
        }
        public void deployParty()
        {

        }
        public void OnCombatStart(Dungeon d)
        {
            if (d.getCurrentRoom(RowLoc, ColumnLoc).Enemy)
            {
                if (d.getCurrentRoom(RowLoc, ColumnLoc).Player)
                {
                    List<MobileObject> enemies = d.getCurrentRoom(RowLoc, ColumnLoc).Enemies;
                    d.getCurrentRoom(RowLoc, ColumnLoc).Enemy = false; 
                    MobileObject enemy1 = enemies.FirstOrDefault();
                    d.Enemies.Remove(enemy1);
                    enemies.Remove(enemies.FirstOrDefault());
                    MobileObject enemy2 = enemies.FirstOrDefault();
                    enemies.Remove(enemies.FirstOrDefault());
                    d.Enemies.Remove(enemy2);
                    MobileObject enemy3 = enemies.FirstOrDefault();
                    enemies.Remove(enemies.FirstOrDefault());
                    d.Enemies.Remove(enemy3);
                    Ally ally1 = party.FirstOrDefault();
                    party.Remove(ally1);
                    Ally ally2 = party.FirstOrDefault();
                    party.Remove(ally2);
                    Form.Ally1 = ally1;
                    Form.Ally2 = ally2;
                    Form.Enemy1 = enemy1;
                    Form.Enemy2 = enemy2;
                    Form.Enemy3 = enemy3;
                    Form.startCombat();
                }
            }
        }
        public void useItem(string str, MobileObject m)
        {
            
        }
        public void outOfCombatUse(string s)
        {
            
        }
        public void healOutOfCombat(int i)
        {
            
        }
        public void pullLever(Dungeon d)
        {
            //if(d.getCurrentRoom(RowLoc, ColumnLoc).HasLever)
            
                d.getCurrentRoom(PcolumnLoc, ProwLoc).Lever.Pulled = true;
            d.getCurrentRoom(PcolumnLoc, ProwLoc).Lever = null;


            if (Lever.getNumberOfPulledLevers() == 4)
            {
                d.unlockExit();
            }
        }
        public void interact(string item, Dungeon d)
        {
            foreach (Item i in d.getCurrentRoom(PcolumnLoc, ProwLoc).Items)
            {
                if(i.ItemName.Equals(item))
                {
                    items.Add(i);
                    d.getCurrentRoom(PcolumnLoc, ProwLoc).Items.Remove(i);
                    break;
                }
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
        
    }
}

