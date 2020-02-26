using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class RNG
    {
        private static Random Rand = new Random();

        public static bool GenerateRandomCellState(int percentChanceOfLive)
        {
            if(percentChanceOfLive < 0 || percentChanceOfLive > 100)
            {
                throw new Exception("Error: percentChanceOfLive must be within 0 and 100");
            }
            return GetRandom(1, 100) < percentChanceOfLive ? true : false;
        }
        private static int GetRandom(int lowerBound, int higherBound) => Rand.Next(lowerBound, higherBound + 1);

    }
}
