using System;

namespace Minesweeper_trial
{
    class Program
    {
        static int PositionXValue;
        static int PositionYValue;
        static bool IsPositionXNumber;
        static bool IsPositionYNumber;

        static void Main(string[] args)
        {
            Mine mine1 = new Mine();
            Mine mine2 = new Mine();
            Mine mine3 = new Mine();
            // Inticiallizes the mines
            //--------------------------------------------------------------------------------------
            Board Gameboard = new Board();
            UserBoard userBoard = new UserBoard();
            // Inticiallizes the Boards
            //--------------------------------------------------------------------------------------
            Gameboard.SetBoard();
            userBoard.SetBoard();
            //sets the boards
            //--------------------------------------------------------------------------------------
            Gameboard.NumberBesideMine(mine1);
            Gameboard.NumberBesideMine(mine2);
            Gameboard.NumberBesideMine(mine3);
            //adds the numbers that are beside the mines
            //--------------------------------------------------------------------------------------
            Gameboard.AddMine(mine1);
            Gameboard.AddMine(mine2);
            Gameboard.AddMine(mine3);
            //adds the mines
            //--------------------------------------------------------------------------------------
            //Gameboard.PrintBoard();
            //userBoard.PrintBoard();
            //prints the boards
            //--------------------------------------------------------------------------------------
            Intro();

            while (!userBoard.Win && !userBoard.Lose)
            {              
                userBoard.PrintBoard();
                //Gameboard.PrintBoard();
                //--------------------------------------------------------------------------------------

                Console.WriteLine("Enter your x and y value in the following manner\nx y");
                String UserInput = Console.ReadLine();
                //--------------------------------------------------------------------------------------

                IsPositionXNumber = int.TryParse(Convert.ToString(UserInput[0]), out PositionXValue);
                IsPositionYNumber = int.TryParse(Convert.ToString(UserInput[2]), out PositionYValue);
                //--------------------------------------------------------------------------------------
                if (IsPositionXNumber && IsPositionYNumber && PositionXValue < 6 && PositionXValue > 0 && PositionYValue < 6 && PositionYValue > 0)
                {
                    Console.WriteLine("Enter d for dig and f for flag.");
                    String DigOrFlag = Console.ReadLine();
                    //--------------------------------------------------------------------------------------

                    switch (DigOrFlag)
                    {
                        case "d":
                            userBoard.ReplaceBoard(PositionXValue - 1, PositionYValue - 1, Gameboard);
                            break;

                        case "f":
                            userBoard.Flag(PositionXValue - 1, PositionYValue - 1, Gameboard, mine1, mine2, mine3);
                            userBoard.FlagsUsed++;
                            userBoard.AllFlagsUsed();
                            break;

                        default:
                            userBoard.ReplaceBoard(PositionXValue - 1, PositionYValue - 1, Gameboard);
                            break;
                    }
                }
            }
            if (userBoard.Win)
            {
                Console.WriteLine("Your Board");
                userBoard.PrintBoard();
                //--------------------------------------------------------------------------------------
                
                Console.WriteLine("Finished Board (#9 is mines)");
                Gameboard.PrintBoard();
                //--------------------------------------------------------------------------------------
                
                Console.WriteLine("Congrats On Winning");
            }
            else if (userBoard.Lose)
            {
                Console.WriteLine("Your Board");
                userBoard.PrintBoard();
                //--------------------------------------------------------------------------------------

                Console.WriteLine("Finished Board (#9 is mines)");
                Gameboard.PrintBoard();
                //--------------------------------------------------------------------------------------

                Console.WriteLine("Better Luck Next Time");
            }
        }
        //--------------------------------------------------------------------------------------
        
        static public void Intro()
        {
            Console.WriteLine("███╗   ███╗██╗███╗   ██╗███████╗    ███████╗██╗    ██╗███████╗███████╗██████╗ ███████╗██████╗ ");
            Console.WriteLine("████╗ ████║██║████╗  ██║██╔════╝    ██╔════╝██║    ██║██╔════╝██╔════╝██╔══██╗██╔════╝██╔══██╗");
            Console.WriteLine("██╔████╔██║██║██╔██╗ ██║█████╗      ███████╗██║ █╗ ██║█████╗  █████╗  ██████╔╝█████╗  ██████╔╝");
            Console.WriteLine("██║╚██╔╝██║██║██║╚██╗██║██╔══╝      ╚════██║██║███╗██║██╔══╝  ██╔══╝  ██╔═══╝ ██╔══╝  ██╔══██╗");
            Console.WriteLine("██║ ╚═╝ ██║██║██║ ╚████║███████╗    ███████║╚███╔███╔╝███████╗███████╗██║     ███████╗██║  ██║");
            Console.WriteLine("╚═╝     ╚═╝╚═╝╚═╝  ╚═══╝╚══════╝    ╚══════╝ ╚══╝╚══╝ ╚══════╝╚══════╝╚═╝     ╚══════╝╚═╝  ╚═╝");
            //--------------------------------------------------------------------------------------

            Console.WriteLine("\nHow to Play:");
            Console.WriteLine("1. Your objective is to flag all the mines. you can flag mines by typing in the position you want to flag. Then type f to flag.");
            Console.WriteLine("2. You can also dig, by typing in the position you want to dig. Then type in d for dig");
            Console.WriteLine("\n");
            //--------------------------------------------------------------------------------------

            Console.WriteLine("Press a key to begin");
            Console.ReadKey();
        }
    }
}