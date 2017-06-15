using DungeonCrawl.UnitClasses;
namespace DungeonCrawl
{
    public class Ally : MobileObject
    {
        public Ally(string name, int hp, int magic, int strength, int speed, UnitClass u)
        {
            Name = name;
            HP = hp;
            MagicPower = magic;
            Strength = strength;
            Speed = speed;
            Class = u;
        }
        public Ally()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
        
    }
}
