using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class ConstructGenerator
    {
        public static void AddGlider(Map map, int x, int y, DiagonalDirection direction)
        {
            switch (direction)
            {
                case DiagonalDirection.UpLeft:
                    map.AddLiveCell(x, y);
                    map.AddLiveCell(x - 1, y - 1);
                    map.AddLiveCell(x - 2, y - 1);
                    map.AddLiveCell(x - 0, y - 2);
                    map.AddLiveCell(x - 1, y - 2);
                    break;
                case DiagonalDirection.UpRight:
                    map.AddLiveCell(x, y);
                    map.AddLiveCell(x + 1, y - 1);
                    map.AddLiveCell(x + 2, y - 1);
                    map.AddLiveCell(x + 0, y - 2);
                    map.AddLiveCell(x + 1, y - 2);
                    break;
                case DiagonalDirection.DownLeft:
                    map.AddLiveCell(x, y);
                    map.AddLiveCell(x - 1, y + 1);
                    map.AddLiveCell(x - 2, y + 1);
                    map.AddLiveCell(x - 0, y + 2);
                    map.AddLiveCell(x - 1, y + 2);
                    break;
                case DiagonalDirection.DownRight:
                    map.AddLiveCell(x, y);
                    map.AddLiveCell(x + 1, y + 1);
                    map.AddLiveCell(x + 2, y + 1);
                    map.AddLiveCell(x + 0, y + 2);
                    map.AddLiveCell(x + 1, y + 2);
                    break;

            }
        }
        public static void AddPulsar(Map map, int x, int y)
        {
            map.AddLiveCell(x + 3, y + 1);
            map.AddLiveCell(x + 4, y + 1);
            map.AddLiveCell(x + 5, y + 1);
            map.AddLiveCell(x + 9, y + 1);
            map.AddLiveCell(x + 10, y + 1);
            map.AddLiveCell(x + 11, y + 1);

            map.AddLiveCell(x + 3, y + 6);
            map.AddLiveCell(x + 4, y + 6);
            map.AddLiveCell(x + 5, y + 6);
            map.AddLiveCell(x + 9, y + 6);
            map.AddLiveCell(x + 10, y + 6);
            map.AddLiveCell(x + 11, y + 6);

            map.AddLiveCell(x + 3, y + 8);
            map.AddLiveCell(x + 4, y + 8);
            map.AddLiveCell(x + 5, y + 8);
            map.AddLiveCell(x + 9, y + 8);
            map.AddLiveCell(x + 10, y + 8);
            map.AddLiveCell(x + 11, y + 8);

            map.AddLiveCell(x + 3, y + 13);
            map.AddLiveCell(x + 4, y + 13);
            map.AddLiveCell(x + 5, y + 13);
            map.AddLiveCell(x + 9, y + 13);
            map.AddLiveCell(x + 10, y + 13);
            map.AddLiveCell(x + 11, y + 13);

            map.AddLiveCell(x + 1, y + 3);
            map.AddLiveCell(x + 1, y + 4);
            map.AddLiveCell(x + 1, y + 5);

            map.AddLiveCell(x + 6, y + 3);
            map.AddLiveCell(x + 6, y + 4);
            map.AddLiveCell(x + 6, y + 5);

            map.AddLiveCell(x + 8, y + 3);
            map.AddLiveCell(x + 8, y + 4);
            map.AddLiveCell(x + 8, y + 5);

            map.AddLiveCell(x + 13, y + 3);
            map.AddLiveCell(x + 13, y + 4);
            map.AddLiveCell(x + 13, y + 5);

            map.AddLiveCell(x + 1, y + 9);
            map.AddLiveCell(x + 1, y + 10);
            map.AddLiveCell(x + 1, y + 11);

            map.AddLiveCell(x + 6, y + 9);
            map.AddLiveCell(x + 6, y + 10);
            map.AddLiveCell(x + 6, y + 11);

            map.AddLiveCell(x + 8, y + 9);
            map.AddLiveCell(x + 8, y + 10);
            map.AddLiveCell(x + 8, y + 11);

            map.AddLiveCell(x + 13, y + 9);
            map.AddLiveCell(x + 13, y + 10);
            map.AddLiveCell(x + 13, y + 11);
        }
        public static void AddPentadecathlon(Map map, int x, int y)
        {
            map.AddLiveCell(x + 3, y + 1);
            map.AddLiveCell(x + 8, y + 1);

            map.AddLiveCell(x + 3, y + 3);
            map.AddLiveCell(x + 8, y + 3);

            map.AddLiveCell(x + 1, y + 2);
            map.AddLiveCell(x + 2, y + 2);
            map.AddLiveCell(x + 4, y + 2);
            map.AddLiveCell(x + 5, y + 2);
            map.AddLiveCell(x + 6, y + 2);
            map.AddLiveCell(x + 7, y + 2);
            map.AddLiveCell(x + 9, y + 2);
            map.AddLiveCell(x + 10, y + 2);
        }
        public static void AddKoksGalaxy(Map map, int x, int y)
        {
            map.AddLiveCell(x + 3, y + 1);
            map.AddLiveCell(x + 6, y + 1);
            map.AddLiveCell(x + 8, y + 1);

            map.AddLiveCell(x + 1, y + 2);
            map.AddLiveCell(x + 2, y + 2);
            map.AddLiveCell(x + 4, y + 2);
            map.AddLiveCell(x + 6, y + 2);
            map.AddLiveCell(x + 7, y + 2);
            map.AddLiveCell(x + 8, y + 2);

            map.AddLiveCell(x + 2, y + 3);
            map.AddLiveCell(x + 9, y + 3);

            map.AddLiveCell(x + 1, y + 4);
            map.AddLiveCell(x + 2, y + 4);
            map.AddLiveCell(x + 8, y + 4);

            map.AddLiveCell(x + 2, y + 6);
            map.AddLiveCell(x + 8, y + 6);
            map.AddLiveCell(x + 9, y + 6);

            map.AddLiveCell(x + 1, y + 7);
            map.AddLiveCell(x + 8, y + 7);

            map.AddLiveCell(x + 2, y + 8);
            map.AddLiveCell(x + 3, y + 8);
            map.AddLiveCell(x + 4, y + 8);
            map.AddLiveCell(x + 6, y + 8);
            map.AddLiveCell(x + 8, y + 8);
            map.AddLiveCell(x + 9, y + 8);

            map.AddLiveCell(x + 2, y + 9);
            map.AddLiveCell(x + 4, y + 9);
            map.AddLiveCell(x + 7, y + 9);
        }
    }

    public enum DiagonalDirection
    {
        UpRight,
        DownRight,
        UpLeft,
        DownLeft

    }
}
