using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class Settings
    {
        public static string VerticalBorder = ". ";
        public static string HorizontalBorder = ". ";
        public static string DeadCell = " ";
        public static string LiveCell = "*";
        public static string WindowTitle = "Game Of Life";
        public static int TickSpeed = 0050;
        public static ConsoleColor LiveCellColor = ConsoleColor.White;
        public static ConsoleColor DefaultFontColor = ConsoleColor.White;
        public static int MapInsetSpacingAmount = 15;
        public static string MapInsetSpacing = "";

        public static void Init()
        {
            
            Console.Title = WindowTitle;
            Console.CursorVisible = false;
            Console.ForegroundColor = DefaultFontColor;
            Console.SetWindowSize(Console.LargestWindowWidth - 230, Console.LargestWindowHeight - 40);
            Console.SetBufferSize(Console.LargestWindowWidth - 230, Console.LargestWindowHeight - 40);
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
