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
        private List<MobileObject> MOBS = new List<MobileObject>();
        private bool doorLocked = false;
        private Player playerObject;
        private Lever lever;
        private bool hasLever = false;
        private bool dungeonExit = false;
        private bool openExit = false;

        
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

        internal List<MobileObject> MOBList
        {
            get
            {
                return MOBS;
            }

            set
            {
                MOBS = value;
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

        public bool DungeonExit
        {
            get
            {
                return dungeonExit;
            }

            set
            {
                dungeonExit = value;
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
        public void Enter(MobileObject MobileOb)
        {
            
            MOBList.Add(MobileOb);
        }
        public void Exit(MobileObject MobileOb)
        {
            player = false;
            removeEntFromList(MobileOb);
        }
        private void removeEntFromList(MobileObject MobileOb)
        {
            foreach (MobileObject m in MOBList)
            {
                
                if(m.Equals(MobileOb))
                {
                    MOBList.Remove(m);
                    break;
                }
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
