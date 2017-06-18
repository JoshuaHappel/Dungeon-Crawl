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
            
        }
        public void interact(string item, Dungeon d)
        {
            
        }
        public void pickUpItem(Item i)
        {
            items.Add(i);
        }
        public override string ToString()
        {
            return base.ToString();
        }
        
    }
}

