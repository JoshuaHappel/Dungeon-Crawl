
namespace DungeonCrawl
{
    public class Lever
    {
        private bool pulled = false;
        private static int numberOfPulledLevers = 0;
        public bool Pulled
        {
            get
            {
                return pulled;
            }

            set
            {
                pulled = value;
                if (pulled == true)
                {
                    numberOfPulledLevers++;
                }
                
            }
        }
        public static int getNumberOfPulledLevers()
        {
            return numberOfPulledLevers;
        }
    }
}
