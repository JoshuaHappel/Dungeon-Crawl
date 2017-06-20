using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.MOBs.Enemies
{
    public class Orc : Enemy
    {
        public Orc()
        {
            HP = 35;
            Strength = 5;
            Speed = 3;
            CanAttack = true;
            Name = "Orc";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
