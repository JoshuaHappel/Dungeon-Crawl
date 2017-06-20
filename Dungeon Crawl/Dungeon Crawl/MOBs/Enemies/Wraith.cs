using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.MOBs.Enemies
{
    public class Wraith : Enemy
    {
        public Wraith()
        {
            HP = 6;
            Strength = 1;
            Speed = 2;
            CanAttack = true;
            Name = "Wraith";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
