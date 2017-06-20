using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.MOBs.Enemies
{
    public class Goblin : Enemy
    {
        public Goblin()
        {
            HP = 10;
            Strength = 1;
            Speed = 6;
            CanAttack = true;
            Name = "Goblin";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
