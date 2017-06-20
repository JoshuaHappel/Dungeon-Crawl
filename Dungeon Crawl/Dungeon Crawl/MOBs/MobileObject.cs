using System;
using System.Text;
using DungeonCrawl.UnitClasses;
using DungeonCrawl.MOBs.Enemies;
using Dungeon_Crawl;

namespace DungeonCrawl
{
    public class MobileObject
    {
        Form1 form;
        private string name = "";//name
        private int xCoor = 0;//x cooridinate 
        private int yCoor = 0;//y cooridinate
        private int hitPoints = 0;
        private int maxHP = 0;
        private Item equippedArmor = null;
        private Item equippedWeapon = null;
        private int strength = 0;
        private int magicPower = 0;
        private int magicWeaponBonus = 0;
        private bool canAttack = false;
        private int speed = 0;
        private UnitClass charClass;
        private int experience = 0;
        private int level = 1;

        public MobileObject()
        {

        }
        public MobileObject(string name, int hp)
        {
            this.name = name;
            hitPoints = hp;
            MaxHP = hp;
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public UnitClass Class
        {
            get { return charClass; }
            set
            {
                charClass = value;
            }
        }
        public int HP
        {
            get { return hitPoints; }
            set { hitPoints = value; }
        }
        
        public int Damage
        {
            get { return (Strength); }
        }
        public int MagicDamage
        {
            get { return (MagicPower + MagicWeaponBonus); }
        }
        public bool CanAttack
        {
            get { return canAttack; }
            set { canAttack = value; }
        }
        public int MagicPower
        {
            get
            {
                return magicPower;
            }

            set
            {
                magicPower = value;
            }
        }
        public Form1 Form
        {
            get
            {
                return form;
            }

            set
            {
                form = value;
            }
        }
        
        public int MagicWeaponBonus
        {
            get
            {
                return magicWeaponBonus;
            }

            set
            {
                magicWeaponBonus = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int XCoor
        {
            get
            {
                return xCoor;
            }

            set
            {
                xCoor = value;
            }
        }

        public int YCoor
        {
            get
            {
                return yCoor;
            }

            set
            {
                yCoor = value;
            }
        }

        public Item EquippedArmor
        {
            get
            {
                return equippedArmor;
            }

            set
            {
                equippedArmor = value;
            }
        }

        public Item EquippedWeapon
        {
            get
            {
                return equippedWeapon;
            }

            set
            {
                equippedWeapon = value;
            }
        }

        public int MaxHP
        {
            get
            {
                return maxHP;
            }

            set
            {
                maxHP = value;
            }
        }

        public void getMap(Form1 form)
        {
            this.Form = form;
        }
        public void OnSpawn()
        {

        }
        public void OnDeath()
        {

        }
        public void attack(MobileObject target)
        {
            if (Class is Mage)
            {
                CombatEngine.magicAttack(this, target);
            }
            else
            {
                CombatEngine.attack(this, target);
            }
        }
        public void useSpecial(MobileObject target)
        {
            charClass.Special(this, target);
        }
        public void go(int direction, Dungeon d)
        {
            d.getCurrentRoom(this).Exit(this);
            switch(direction)
            {
                case 0://north
                    yCoor -= 1;
                    if (yCoor < 0)
                        yCoor = 0;
                    break;
                case 1://south
                    yCoor += 1;
                    if (yCoor > 4)
                        yCoor = 4;
                    break;
                case 2://east
                    xCoor += 1;
                    if (xCoor > 4)
                        xCoor = 4;
                    break;
                case 3://west
                    xCoor -= 1;
                    if (xCoor < 0)
                        xCoor = 0;
                    break;
           }
           d.getCurrentRoom(this).Enter(this);
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Name: " + name + "\n");
            str.Append("HitPoints: " + HP + "\n");
            str.Append("Strength: " + strength + "\n");
            str.Append("Magic Power: " + magicPower + "\n");
            str.Append("Magic Weapon Bonus: " + magicWeaponBonus + "\n");
            str.Append("Speed: " + speed + "\n");
            return str.ToString();
        }
        public void goNPC(string direction, Dungeon d)
        {
            
        }
        public void npcIdleMove(Dungeon d, MobileObject e)
        {
            
            Random rand1 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        //if direction is = to zero npc will not move this gives a chance an npc will do nothing while in idle state
       
        }
        /**
        this method is called if the player alerts the enemies the npcs know where the player is and now are seeking I subtract the enemy's location from the player's
            and run it through a few if else if statements trying to make the difference for both x and y 0;
        */
        public void npcSeekingMove(Dungeon d, MobileObject e, Player play)
        {
            
        }
        
    }
}
