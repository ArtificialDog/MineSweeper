using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_trial
{
    class Board
    {
        public int[,] BoardPeices = new int[5, 5];
        //--------------------------------------------------------------------------------------
        public void AddMine(Mine mine1)
        {
            BoardPeices[mine1.PositionX, mine1.PositionY] = 9;
        }
        //--------------------------------------------------------------------------------------
        public void PrintBoard()
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write(BoardPeices[x,y]);
                }
                Console.Write(Environment.NewLine);
            }
        }
        //--------------------------------------------------------------------------------------
        public void SetBoard()
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    BoardPeices[x, y] = 0;
                }
            }
        }
        //--------------------------------------------------------------------------------------
        public void NumberBesideMine(Mine mine1)
        {
            if (mine1.PositionX == 4 && mine1.PositionY == 4)
            {
                BoardPeices[mine1.PositionX - 1, mine1.PositionY]++;
                BoardPeices[mine1.PositionX, mine1.PositionY - 1]++;
                BoardPeices[mine1.PositionX - 1, mine1.PositionY - 1]++;
            }
            else if (mine1.PositionX == 0 && mine1.PositionY == 0)
            {
                BoardPeices[mine1.PositionX + 1, mine1.PositionY]++;
                BoardPeices[mine1.PositionX, mine1.PositionY + 1]++;
                BoardPeices[mine1.PositionX + 1, mine1.PositionY + 1]++;
            }
            else if (mine1.PositionX == 0 && mine1.PositionY == 4)
            {
                BoardPeices[mine1.PositionX + 1, mine1.PositionY]++;
                BoardPeices[mine1.PositionX, mine1.PositionY - 1]++;
                BoardPeices[mine1.PositionX + 1, mine1.PositionY - 1]++;
            }
            else if (mine1.PositionX == 4 && mine1.PositionY == 0)
            {
                BoardPeices[mine1.PositionX - 1, mine1.PositionY]++;
                BoardPeices[mine1.PositionX, mine1.PositionY + 1]++;
                BoardPeices[mine1.PositionX - 1, mine1.PositionY + 1]++;
            }
            else  if (mine1.PositionY == 4)
            {
                BoardPeices[mine1.PositionX + 1, mine1.PositionY]++;
                BoardPeices[mine1.PositionX - 1, mine1.PositionY]++;
                BoardPeices[mine1.PositionX, mine1.PositionY - 1]++;
                BoardPeices[mine1.PositionX + 1, mine1.PositionY - 1]++;
                BoardPeices[mine1.PositionX - 1, mine1.PositionY - 1]++;
            }
            else if (mine1.PositionX == 4)
            {
                BoardPeices[mine1.PositionX - 1, mine1.PositionY]++;
                BoardPeices[mine1.PositionX, mine1.PositionY + 1]++;
                BoardPeices[mine1.PositionX, mine1.PositionY - 1]++;
                BoardPeices[mine1.PositionX - 1, mine1.PositionY + 1]++;
                BoardPeices[mine1.PositionX - 1, mine1.PositionY - 1]++;
            }
            else if (mine1.PositionY == 0)
            {
                BoardPeices[mine1.PositionX + 1, mine1.PositionY]++;
                BoardPeices[mine1.PositionX - 1, mine1.PositionY]++;
                BoardPeices[mine1.PositionX, mine1.PositionY + 1]++;
                BoardPeices[mine1.PositionX + 1, mine1.PositionY + 1]++;
                BoardPeices[mine1.PositionX - 1, mine1.PositionY + 1]++;
            }
            else if (mine1.PositionX == 0)
            {
                BoardPeices[mine1.PositionX + 1, mine1.PositionY]++;
                BoardPeices[mine1.PositionX, mine1.PositionY + 1]++;
                BoardPeices[mine1.PositionX, mine1.PositionY - 1]++;
                BoardPeices[mine1.PositionX + 1, mine1.PositionY - 1]++;
                BoardPeices[mine1.PositionX + 1, mine1.PositionY + 1]++;
            }
            else
            {
                BoardPeices[mine1.PositionX + 1, mine1.PositionY]++;
                BoardPeices[mine1.PositionX - 1, mine1.PositionY]++;
                BoardPeices[mine1.PositionX, mine1.PositionY + 1]++;
                BoardPeices[mine1.PositionX, mine1.PositionY - 1]++;
                BoardPeices[mine1.PositionX + 1, mine1.PositionY - 1]++;
                BoardPeices[mine1.PositionX + 1, mine1.PositionY + 1]++;
                BoardPeices[mine1.PositionX - 1, mine1.PositionY + 1]++;
                BoardPeices[mine1.PositionX - 1, mine1.PositionY - 1]++;
            }
        }
    }
}
