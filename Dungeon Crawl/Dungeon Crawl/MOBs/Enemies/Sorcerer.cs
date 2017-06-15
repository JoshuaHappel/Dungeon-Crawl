using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.MOBs.Enemies
{
    public class Sorcerer : Enemy
    {
        
        public Sorcerer()
        {
            HP = 30;
            Strength = 5;
            WeaponBonus = 2;
            ArmorClass = 4;
            Speed = 5;
            CanAttack = true;
            Name = "Sorcerer";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
