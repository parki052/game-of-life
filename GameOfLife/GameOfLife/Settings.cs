using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class Settings
    {
        //edit the ascii characters here if desired
        public static string VerticalBorder = ". ";
        public static string HorizontalBorder = ". ";
        public static string DeadCell = " ";
        public static string LiveCell = "*";

        public static string WindowTitle = "Game Of Life";
        public static int TickSpeed = 0050; //tick speed in MS
        public static ConsoleColor LiveCellColor = ConsoleColor.Green;
        public static ConsoleColor DefaultFontColor = ConsoleColor.Green;
        public static int MapInsetSpacingAmount = 15; //how many spaces to the right should the grid be set?
        public static string MapInsetSpacing = "";

        public static void Init()
        {
            
            Console.Title = WindowTitle;
            Console.CursorVisible = false;
            Console.ForegroundColor = DefaultFontColor;
            Console.SetWindowSize(Console.LargestWindowWidth - 100, Console.LargestWindowHeight - 20);
            Console.SetBufferSize(Console.LargestWindowWidth - 100, Console.LargestWindowHeight - 20);
            SetMapInsetSpacing();
        }

        private static void SetMapInsetSpacing()
        {
            for(int i = 0; i <= MapInsetSpacingAmount; i++)
            {
                MapInsetSpacing += " ";
            }
        }
    }
}
