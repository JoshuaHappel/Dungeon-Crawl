using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.UnitClasses;
namespace DungeonCrawl
{
    public class Marksman : UnitClass
    {
        public Marksman()
        {
            CanEquipGuns = true;
            MediumArmor = true;
        }
        public override void Special(MobileObject caster, MobileObject target)
        {
            Random rand1 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            if (rand1.Next(100) + 1 > 75)
            {
                target.HP = 0;
            }
        }
    }
}
