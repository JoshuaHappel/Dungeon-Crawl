using DungeonCrawl.UnitClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.UnitClasses
{ 
    public class Defender : UnitClass
    {
        public Defender()
        {
            CanEquipSwords = true;
            HeavyArmor = true;
            MediumArmor = true;
            FriendlySpecial = true;
        }
        public override void Special(MobileObject caster, MobileObject target)
        {
            //fill later
        }
    }
}
