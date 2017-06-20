using System;
using DungeonCrawl.MOBs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl;

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
        public void use(MobileObject target, Player play)
        {
            switch(itemType)
            {
                case "Consumable":
                    target.HP += itemPower;//adds consumable's power to target's health
                    play.Items.Remove(this);//remove item from inventory
                    if (target.HP > target.MaxHP)//ensures that mob cannot have infinite hp
                        target.HP = target.MaxHP;
                    break;
                case "HeavyArmor":
                    if(target.Class.HeavyArmor)
                    {
                        if (target.EquippedArmor != null)//check if target is wearing any armor
                        {
                            play.Items.Add(target.EquippedArmor);//returns equipped armor to player inventory if it is being replaced
                        }
                        target.EquippedArmor = this;//sets equipped armor
                        play.Items.Remove(this);//ensures that no other party member can equip same equipment
                    }
                    break;
                case "MediumArmor":
                    if(target.Class.MediumArmor)
                    {
                        if (target.EquippedArmor != null)
                        {
                            play.Items.Add(target.EquippedArmor);//returns equipped armor to player inventory if it is being replaced
                        }
                        target.EquippedArmor = this;
                        play.Items.Remove(this);
                    }
                    break;
                case "LightArmor"://all classes can equip lightarmor so no need to check the class
                    if (target.EquippedArmor != null)
                    {
                        play.Items.Add(target.EquippedArmor);//returns equipped armor to player inventory if it is being replaced
                    }
                    target.EquippedArmor = this;
                    play.Items.Remove(this);
                    break;
                case "GreatSword"://basically the same as equipping armor but there are more options
                    if(target.Class.CanEquipGreatSwords)
                    {
                        if(target.EquippedWeapon != null)
                        {
                            play.Items.Add(target.EquippedWeapon);
                        }
                        target.EquippedWeapon = this;
                        play.Items.Remove(this);
                    }
                    break;
                case "Gun":
                    if (target.Class.CanEquipGuns)
                    {
                        if (target.EquippedWeapon != null)
                        {
                            play.Items.Add(target.EquippedWeapon);
                        }
                        target.EquippedWeapon = this;
                        play.Items.Remove(this);
                    }
                    break;
                case "ShortSword":
                    if (target.Class.CanEquipSwords)
                    {
                        if (target.EquippedWeapon != null)
                        {
                            play.Items.Add(target.EquippedWeapon);
                        }
                        target.EquippedWeapon = this;
                        play.Items.Remove(this);
                    }
                    break;
                case "Knife":
                    if (target.EquippedWeapon != null)
                    {
                        play.Items.Add(target.EquippedWeapon);
                    }
                    target.EquippedWeapon = this;
                    play.Items.Remove(this);
                    break;
                case "Staff":
                    if (target.Class.CanEquipStaves)
                    {
                        if (target.EquippedWeapon != null)
                        {
                            play.Items.Add(target.EquippedWeapon);
                        }
                        target.EquippedWeapon = this;
                        play.Items.Remove(this);
                    }
                    break;
            }
        }
    }
}
