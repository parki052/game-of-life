using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        private static Map Map { get; set; }
        static void Main(string[] args)
        {          
            Settings.Init();

            Map = new Map(20, 20); //create a map of the given x and y dimensions
            StatePresets.RandomState(Map, 40); //initialize the map with cells state determined randomly, given a percent chance of a cell to be alive

            //        ** other state presets **

            //StatePresets.KoksGalaxy(Map);
            //StatePresets.Pentadecathlon(Map);
            //StatePresets.FourCornerGliders(Map);

            Map.PlayGame();        
        }
    }
}
