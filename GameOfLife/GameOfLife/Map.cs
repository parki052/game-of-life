using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Map
    {
        public int[,] State { get; set; }
        public int ZeroBasedLength { get; set; }
        public int ZeroBasedHeight { get; set; }

        public Map(int length, int height)
        {
            State = new int[length, height];
            ZeroBasedLength = length - 1;
            ZeroBasedHeight = height - 1;

            SetAllCellsToDead();
        }

        private void UpdateState()
        {
            int[,] NewState = (int[,])State.Clone();

            for (int y = 0; y <= ZeroBasedHeight; y++)
            {

                for (int x = 0; x <= ZeroBasedLength; x++)
                {
                    var liveNeighborsCount = 0;

                    if (y > 0 && x > 0) //upleft check
                    {
                        if (CheckIfCellIsAlive(x - 1, y - 1))
                        { liveNeighborsCount++; }
                    }

                    if (y > 0) //up check
                    {
                        if (CheckIfCellIsAlive(x, y - 1))
                        { liveNeighborsCount++; }
                    }

                    if (y > 0 && x < ZeroBasedLength) //upright check
                    {
                        if (CheckIfCellIsAlive(x + 1, y - 1))
                        { liveNeighborsCount++; }
                    }

                    if (x < ZeroBasedLength) //right check
                    {
                        if (CheckIfCellIsAlive(x + 1, y))
                        { liveNeighborsCount++; }
                    }

                    if (y < ZeroBasedHeight && x < ZeroBasedLength) //downright check
                    {
                        if (CheckIfCellIsAlive(x + 1, y + 1))
                        { liveNeighborsCount++; }
                    }

                    if (y < ZeroBasedHeight) //down check
                    {
                        if (CheckIfCellIsAlive(x, y + 1))
                        { liveNeighborsCount++; }
                    }

                    if (y < ZeroBasedHeight && x > 0) //downleft check
                    {
                        if (CheckIfCellIsAlive(x - 1, y + 1))
                        { liveNeighborsCount++; }
                    }

                    if (x > 0) //left check
                    {
                        if (CheckIfCellIsAlive(x - 1, y))
                        { liveNeighborsCount++; }
                    }

                    bool thisCellAlive = CheckIfCellIsAlive(x, y);

                    if (thisCellAlive)
                    {
                        if (liveNeighborsCount < 2)
                        { thisCellAlive = false; }
                        if (liveNeighborsCount == 2 || liveNeighborsCount == 3)
                        { thisCellAlive = true; }
                        if (liveNeighborsCount > 3)
                        { thisCellAlive = false; }
                    }
                    if (!thisCellAlive && liveNeighborsCount == 3)
                    { thisCellAlive = true; }

                    NewState[x, y] = thisCellAlive ? 1 : 0;
                }
            }

            State = (int[,])NewState.Clone();
        }
        public void PlayGame()
        {
            while (true)
            {
                DrawMap(GetBoardString());
                Thread.Sleep(Settings.TickSpeed);
                UpdateState();
            }
        }

        private bool CheckIfCellIsAlive(int x, int y) => State[x, y] == 1;
        public void AddLiveCell(int x, int y) => State[x, y] = 1;
        public void KillCell(int x, int y) => State[x, y] = 0;
        private void SetAllCellsToDead()
        {
            for (int y = 0; y <= ZeroBasedHeight; y++)
            {
                //going down a row

                for (int x = 0; x <= ZeroBasedLength; x++)
                {
                    //going across a row 
                    KillCell(x, y);
                }
            }
        }

        private string GetBoardString()
        {
            var sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            sb.Append(Settings.MapInsetSpacing);
            sb.Append(GetHorizontalSeparator());
            sb.AppendLine();

            for (int y = 0; y <= ZeroBasedHeight; y++)
            {
                //going down a row
                sb.Append(Settings.MapInsetSpacing);
                sb.Append(Settings.VerticalBorder + ' ');

                for (int x = 0; x <= ZeroBasedLength; x++)
                {
                    //going across a row 
                    sb.Append(CheckIfCellIsAlive(x, y) ? Settings.LiveCell + ' ' : Settings.DeadCell + ' ');
                }

                sb.Append(Settings.VerticalBorder + ' ');
                sb.AppendLine();
            }

            sb.Append(Settings.MapInsetSpacing);
            sb.Append(GetHorizontalSeparator());
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();

            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            
            return sb.ToString();
        }
        private void DrawMap(string mapString)
        {
            foreach (var character in mapString)
            {
                if (character == Settings.LiveCell[0])
                {
                    WriteInColor(character);
                }
                else
                {
                    Console.Out.WriteAsync(character);
                }
            }
        }
        private void WriteInColor(char character)
        {
            Console.ForegroundColor = Settings.LiveCellColor;
            Console.Out.WriteAsync(character);
            Console.ForegroundColor = Settings.DefaultFontColor;
        }
        private string GetHorizontalSeparator()
        {
            var sep = "";
            for (int i = 0; i <= ZeroBasedLength + 2; i++) { sep += Settings.HorizontalBorder; }
            return sep;
        }
    }
}
