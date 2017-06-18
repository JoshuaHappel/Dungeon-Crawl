using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawl
{
    public class Item
    {
        private int itemId = 0;
        private String itemName = "";
        private int itemPower = 0;
        private int goldValue = 0;
        private String itemType = "";
        #region properties
        public int ItemPower
        {
            get
            {
                return itemPower;
            }

            set
            {
                itemPower = value;
            }
        }

        public int GoldValue
        {
            get
            {
                return goldValue;
            }

            set
            {
                goldValue = value;
            }
        }

        

        public int ItemId
        {
            get
            {
                return itemId;
            }

            set
            {
                itemId = value;
            }
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }

        public string ItemType
        {
            get
            {
                return itemType;
            }

            set
            {
                itemType = value;
            }
        }
        #endregion
        public Item()
        {

        }
        public override string ToString()
        {

            return ItemName;
        }
    }
}
