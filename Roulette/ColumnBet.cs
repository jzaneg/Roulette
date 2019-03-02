using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class ColumnBet : IPlayerBet
    {
        int BetByColumns;
        bool result;

        public ColumnBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which column do you want to bet on?\nPress 1, 2, or 3\n1: numbers 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, and 34.\n2: numbers 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, and 35.\n3: numbers 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, and 36.");
            BetByColumns = int.Parse(Console.ReadLine());
        }

        public bool BetDidWin()
        {
            RouletteWheel num = new RouletteWheel();
            var number = num.SpinWheel();
            List<int> columnOne = new List<int> {1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34};
            List<int> columnTwo = new List<int> {2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35};
            List<int> columnThree = new List<int> {3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36};

            if (BetByColumns == 1)
            {
                if (columnOne.Contains(number.value))
                {
                    Console.WriteLine("Congrats! You've Won!");
                    result = true;
                }
                else
                {
                    Console.WriteLine("I'm sorry, your bet lost.");
                    result = false;
                }
            }
            else if (BetByColumns == 2)
            {
                if (columnTwo.Contains(number.value))
                {
                    Console.WriteLine("Congrats! You've Won!");
                    result = true;
                }
                else
                {
                    Console.WriteLine("I'm sorry, your bet lost.");
                    result = false;
                }
            }
            else if (BetByColumns == 3)
            {
                if (columnThree.Contains(number.value))
                {
                    Console.WriteLine("Congrats! You've Won!");
                    result = true;
                }
                else
                {
                    Console.WriteLine("I'm sorry, your bet lost.");
                    result = false;
                }
            }
            return result;
        }
    }
}
