using DungeonCrawl.UnitClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public class Fighter : UnitClass
    {
        public Fighter()
        {
            MediumArmor = true;
            CanEquipSwords = true;
            CanEquipGreatSwords = true;
        }
        public override void Special(MobileObject caster, MobileObject target)
        {
            CombatEngine.attack(caster, target);
        }
    }
}
