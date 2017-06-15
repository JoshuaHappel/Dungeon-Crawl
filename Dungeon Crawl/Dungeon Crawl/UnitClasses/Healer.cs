using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.UnitClasses;
namespace DungeonCrawl
{
    public class Healer : UnitClass
    {
        public Healer()
        {
            CanEquipStaves = true;
            FriendlySpecial = true;
        }
        public override void Special(MobileObject caster, MobileObject target)
        {
            target.HP += caster.MagicDamage;
        }
        
    }
}
