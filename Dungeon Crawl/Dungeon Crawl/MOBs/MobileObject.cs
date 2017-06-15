using System;
using System.Text;
using DungeonCrawl.UnitClasses;
using DungeonCrawl.MOBs.Enemies;
namespace DungeonCrawl
{
    public class MobileObject
    {
        Form1 form;
        private string name = "";
        private int columnLoc = 0;
        private int rowLoc = 0;
        private int pcolumnLoc = 0;
        private int prowLoc = 0;
        private int pOldXLoc = 0;
        private int pOldYLoc = 0;
        private int hitPoints = 0;
        private int armorClass = 0;
        private int strength = 0;
        private int magicPower = 0;
        private int weaponBonus = 0;
        private int magicWeaponBonus = 0;
        private bool canAttack = false;
        private int speed = 0;
        private UnitClass charClass;
        private int experience = 0;
        private int level = 1;

        public MobileObject()
        {

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
        public int ArmorClass
        {
            get { return armorClass; }
            set { armorClass = value; }
        }
        public int Damage
        {
            get { return (Strength + WeaponBonus); }
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
        public int ColumnLoc
        {
            get
            {
                return columnLoc;
            }

            set
            {
                columnLoc = value;
            }
        }
        public int RowLoc
        {
            get
            {
                return rowLoc;
            }

            set
            {
                rowLoc = value;
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
        public int WeaponBonus
        {
            get
            {
                return weaponBonus;
            }

            set
            {
                weaponBonus = value;
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
        public int PcolumnLoc
        {
            get
            {
                return pcolumnLoc;
            }

            set
            {
                pcolumnLoc = value;
            }
        }
        public int ProwLoc
        {
            get
            {
                return prowLoc;
            }

            set
            {
                prowLoc = value;
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
        public void go(string direction, Dungeon d)
        {
            pOldXLoc = PcolumnLoc;
            pOldYLoc = ProwLoc;
            switch (direction)
            {
                case "north":
                    ProwLoc -= 1;
                    if (ProwLoc < 0)
                        ProwLoc = 0;
                    break;
                case "south":
                    ProwLoc += 1;
                    if (ProwLoc > 4)
                        ProwLoc = 4;
                    break;
                case "west":
                    PcolumnLoc -= 1;
                    if (PcolumnLoc < 0)
                        PcolumnLoc = 0;
                    break;
                case "east":
                    PcolumnLoc += 1;
                    if (PcolumnLoc > 4)
                        PcolumnLoc = 4;
                    break;
            }
            d.movePlayer(pOldXLoc, pOldYLoc, PcolumnLoc, ProwLoc);
            Form.updatePosition(PcolumnLoc, ProwLoc);
            if (d.getCurrentRoom(rowLoc, columnLoc).Enemy)
            {
                d.Player.OnCombatStart(d);
            }
            else
            {
                
                if (d.Player.MadeNoise)
                {
                    foreach (Enemy e in d.Enemies)
                    {
                        npcSeekingMove(d,e, d.Player);
                    }
                }
                else
                {
                    foreach (Enemy e in d.Enemies)
                    {
                        npcIdleMove(d, e);
                    }
                }
                
            }
            
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Name: " + name + "\n");
            str.Append("HitPoints: " + HP + "\n");
            str.Append("Strength: " + strength + "\n");
            str.Append("Magic Power: " + magicPower + "\n");
            str.Append("Weapon Bonus: " + weaponBonus + "\n");
            str.Append("Magic Weapon Bonus: " + magicWeaponBonus + "\n");
            str.Append("Armor: " + armorClass + "\n");
            str.Append("Speed: " + speed + "\n");
            return str.ToString();
        }
        public void goNPC(string direction, Dungeon d)
        {
            int oldX = ColumnLoc;
            int oldY = RowLoc;
            switch (direction)
            {
                case "north":
                    RowLoc -= 1;
                    if (RowLoc < 0)
                        RowLoc = 0;
                    break;
                case "south":
                    RowLoc += 1;
                    if (RowLoc > 4)
                        RowLoc = 4;
                    break;
                case "west":
                    ColumnLoc -= 1;
                    if (ColumnLoc < 0)
                        ColumnLoc = 0;
                    break;
                case "east":
                    ColumnLoc += 1;
                    if (ColumnLoc > 4)
                        ColumnLoc = 4;
                    break;
            }
            foreach (MobileObject m in d.Enemies)
            {
                d.moveEnemy(oldY, oldX, RowLoc, ColumnLoc, m);
            }
            if (d.getCurrentRoom(rowLoc, columnLoc).Player)
            {
                d.Player.OnCombatStart(d);
            }
        }
        public void npcIdleMove(Dungeon d, MobileObject e)
        {
            int oldX = ColumnLoc;
            int oldY = RowLoc;
            Random rand1 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        //if direction is = to zero npc will not move this gives a chance an npc will do nothing while in idle state
        int direction = rand1.Next(5);
            if(direction == 1)
            {
                RowLoc -= 1;
                if (RowLoc < 0)
                {
                    RowLoc = 0;
                }
            }
            if(direction == 2)
            {
                RowLoc += 1;
                if (RowLoc > 4)
                    RowLoc = 4;
            }
            if (direction == 3)
            {
                ColumnLoc -= 1;
                if (ColumnLoc < 0)
                    ColumnLoc = 0;
            }
            if(direction == 4)
            {
                ColumnLoc += 1;
                if (ColumnLoc > 4)
                    ColumnLoc = 4;
            }
            d.moveEnemy(oldX, oldY, ColumnLoc, RowLoc, e);
        }
        /**
        this method is called if the player alerts the enemies the npcs know where the player is and now are seeking I subtract the enemy's location from the player's
            and run it through a few if else if statements trying to make the difference for both x and y 0;
        */
        public void npcSeekingMove(Dungeon d, MobileObject e, Player play)
        {
            int xDifference;
            int yDifference;
            xDifference = (play.RowLoc - rowLoc);
            yDifference = (play.ColumnLoc - columnLoc);
            if(xDifference < 0)
            {
                goNPC("east", d);
            }
            else if (xDifference > 0)
            {
                goNPC("west", d);
            }
            else if (yDifference < 0)
            {
                goNPC("north", d);
            }
            else if (yDifference > 0)
            {
                goNPC("south", d);
            }
        }
    }
}
