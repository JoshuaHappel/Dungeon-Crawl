using DungeonCrawl.UnitClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawl.UnitClasses
{
    class Peasant : UnitClass
    {
        public Peasant()
        {
            CanEquipKnives = true;
            LightArmor = true;
        }
    }
}
