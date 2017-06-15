using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.MOBs.Enemies
{
    public class Enemy : MobileObject
    {
        private bool ability = false;

        public bool Ability
        {
            get
            {
                return ability;
            }

            set
            {
                ability = value;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
