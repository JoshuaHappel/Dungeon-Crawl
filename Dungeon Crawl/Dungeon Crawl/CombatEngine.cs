using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class CombatEngine
    {
//      private static Boss boss;
//      private static Player player;
        public CombatEngine()
        {
            
        }
        public static void attack(MobileObject a, MobileObject b)
        {
            if(b != null)
            b.HP -= a.Damage - b.ArmorClass;
        }
        public static void magicAttack(MobileObject a, MobileObject b)
        {
            b.HP -= a.MagicDamage;
        }
  }
}
