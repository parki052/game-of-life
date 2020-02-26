using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class StatePresets
    {
        public static void TwoGliders(Map map)
        {
            ConstructGenerator.AddGlider(map, 0, 0, DiagonalDirection.DownRight);
            ConstructGenerator.AddGlider(map, 5, 0, DiagonalDirection.DownRight);
        }

        public static void FourCornerGliders(Map map)
        {
            ConstructGenerator.AddGlider(map, 0, 0, DiagonalDirection.DownRight);
            ConstructGenerator.AddGlider(map, map.ZeroBasedLength - 0, 0, DiagonalDirection.DownLeft);
            ConstructGenerator.AddGlider(map, 0, map.ZeroBasedHeight - 0, DiagonalDirection.UpRight);
            ConstructGenerator.AddGlider(map, map.ZeroBasedLength - 0, map.ZeroBasedHeight - 0, DiagonalDirection.UpLeft);
        }

        public static void ThreeCornerGliders(Map map)
        {
            ConstructGenerator.AddGlider(map, 0, 0, DiagonalDirection.DownRight);
            ConstructGenerator.AddGlider(map, 0, map.ZeroBasedHeight - 0, DiagonalDirection.UpRight);
            ConstructGenerator.AddGlider(map, map.ZeroBasedLength - 0, map.ZeroBasedHeight - 0, DiagonalDirection.UpLeft);
        }

        public static void Pentadecathlon(Map map)
        {
            ConstructGenerator.AddPentadecathlon(map, 4, 8);
        }

        public static void KoksGalaxy(Map map)
        {
            ConstructGenerator.AddKoksGalaxy(map, 4, 6);
        }

        public static void RandomState(Map map, int percentChanceOfLive)
        {
            for (int y = 0; y <= map.ZeroBasedHeight; y++)
            {
                //going down a row

                for (int x = 0; x <= map.ZeroBasedLength; x++)
                {
                    //going across a row 
                    map.State[x, y] = RNG.GenerateRandomCellState(percentChanceOfLive) ? 1 : 0;
                }
            }
        }
    }
}
