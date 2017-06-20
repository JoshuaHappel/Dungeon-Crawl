using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public static class CombatEngine
    {
        //      private static Boss boss;
        //      private static Player player;
        private static List<MobileObject> playerTeam = new List<MobileObject>();
        private static List<MobileObject> enemyTeam = new List<MobileObject>();
        private static List<MobileObject> attackQueue = new List<MobileObject>();

        public static List<MobileObject> PlayerTeam
        {
            get
            {
                return playerTeam;
            }

            set
            {
                playerTeam = value;
            }
        }

        public static List<MobileObject> EnemyTeam
        {
            get
            {
                return enemyTeam;
            }

            set
            {
                enemyTeam = value;
            }
        }

        public static List<MobileObject> AttackQueue
        {
            get
            {
                return attackQueue;
            }

            set
            {
                attackQueue = value;
            }
        }

        
        public static void attack(MobileObject a, MobileObject b)
        {
            if(b != null)
            b.HP -= a.Damage;
        }
        public static void useSpecial(MobileObject user, MobileObject target)
        {
            if (target != null)
                user.Class.Special(user, target);
        }
        public static void magicAttack(MobileObject a, MobileObject b)
        {
            b.HP -= a.MagicDamage;
        }
  }
}
