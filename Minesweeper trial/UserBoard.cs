using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_trial
{
    class UserBoard
    {
        public string[,] BoardPeices = new string[5, 5];
        public bool Lose = false;
        public bool Win = false;
        public int FlagsUsed = 0;
        //--------------------------------------------------------------------------------------
        public void PrintBoard()
        {
            Console.Clear();

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write(BoardPeices[x, y]);
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
                    BoardPeices[x, y] = "#";
                }
            }
        }
        //--------------------------------------------------------------------------------------
        public void ReplaceBoard(int x, int y, Board gameBoard)
        {
            BoardPeices[x, y] = Convert.ToString(gameBoard.BoardPeices[x, y]);

            if (String.Equals(BoardPeices[x, y], "9"))
            {
                Lose = true;
            }
        }
        //--------------------------------------------------------------------------------------
        public void AllFlagsUsed()
        {
            if (FlagsUsed >= 3)
            {
                Lose = true;
            }
        }
        //--------------------------------------------------------------------------------------
        public void Flag(int x, int y, Board gameBoard, Mine mine1, Mine mine2, Mine mine3)
        {
            BoardPeices[x, y] = "f";

            if (String.Equals(BoardPeices[mine1.PositionX, mine1.PositionY], "f"))
            {
                if (String.Equals(BoardPeices[mine2.PositionX, mine2.PositionY], "f"))
                {
                    if (String.Equals(BoardPeices[mine3.PositionX, mine3.PositionY], "f"))
                    {
                        Win = true;
                    }
                }
                else if (String.Equals(BoardPeices[mine3.PositionX, mine3.PositionY], "f"))
                {
                    if (String.Equals(BoardPeices[mine2.PositionX, mine2.PositionY], "f"))
                    {
                        Win = true;
                    }
                }
            }
            else if (String.Equals(BoardPeices[mine2.PositionX, mine2.PositionY], "f"))
            {
                if (String.Equals(BoardPeices[mine1.PositionX, mine1.PositionY], "f"))
                {
                    if (String.Equals(BoardPeices[mine3.PositionX, mine3.PositionY], "f"))
                    {
                        Win = true;
                    }
                }
                else if (String.Equals(BoardPeices[mine3.PositionX, mine3.PositionY], "f"))
                {
                    if (String.Equals(BoardPeices[mine1.PositionX, mine1.PositionY], "f"))
                    {
                        Win = true;
                    }
                }
            }
            else if ( String.Equals(BoardPeices[mine3.PositionX, mine3.PositionY], "f"))
            {
                if (String.Equals(BoardPeices[mine2.PositionX, mine2.PositionY], "f"))
                {
                    if (String.Equals(BoardPeices[mine1.PositionX, mine1.PositionY], "f"))
                    {
                        Win = true;
                    }
                }
                else if (String.Equals(BoardPeices[mine1.PositionX, mine1.PositionY], "f"))
                {
                    if (String.Equals(BoardPeices[mine2.PositionX, mine2.PositionY], "f"))
                    {
                        Win = true;
                    }
                }
            }
        }        
    }
}
