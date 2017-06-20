using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.MOBs.Enemies
{
    public class Uruk_Hai : Enemy
    {
        //Uruks need to spawn after the player has leveled up a bit
        //Uruks add 4 to strength when health is low
        public Uruk_Hai()
        {
            HP = 50;
            Strength = 8;
            Speed = 4;
            CanAttack = true;
            Name = "Uruk-Hai";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
