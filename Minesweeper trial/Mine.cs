using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_trial
{
    public class Mine
    {

        public int PositionX = RandomGenerator();
        public int PositionY = RandomGenerator();
        //-------------------------------------------------------------------------------------
        public void PrintPosition()
        {
            Console.WriteLine($"{PositionX} {PositionY}");
        }
        //--------------------------------------------------------------------------------------
        static int RandomGenerator()
        {
            Random myRand = new Random();
            return myRand.Next(0, 5);
        }
    }
}