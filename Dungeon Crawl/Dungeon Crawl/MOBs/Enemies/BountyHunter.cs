using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.MOBs.Enemies
{
    public class BountyHunter : Enemy
    {
        //BountyHunters increase speed when health is low
        public BountyHunter()
        {
            HP = 30;
            Strength = 5;
            Speed = 4;
            CanAttack = true;
            Name = "Bounty Hunter";
        }
    }
}
