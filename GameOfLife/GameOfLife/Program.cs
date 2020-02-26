using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Settings.Init();
            var map = new Map(30, 30);
            StatePresets.RandomState(map, 40);
            map.PlayGame();
            
        }
    }
}
