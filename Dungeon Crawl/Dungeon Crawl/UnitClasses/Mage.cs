using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.UnitClasses;
namespace DungeonCrawl
{
    public class Mage : UnitClass
    {
        public Mage()
        {
            CanEquipStaves = true;
        }
        public override void Special(MobileObject caster, MobileObject target)
        {
            target.HP -= caster.MagicPower * 2;
        }
    }
}
