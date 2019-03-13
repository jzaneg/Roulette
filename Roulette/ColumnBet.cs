using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class ColumnBet : RouletteWheel, IPlayerBet
    {
        int BetByColumns = 0;
        bool result;

        public ColumnBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which column do you want to bet on?\nPress 1, 2, or 3\n1: numbers 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, and 34.\n2: numbers 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, and 35.\n3: numbers 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, and 36.");
            while (BetByColumns < 1 || BetByColumns > 3)
            {
                try
                {
                    BetByColumns = int.Parse(Console.ReadLine());
                    if (BetByColumns < 1 || BetByColumns > 3)
                    {
                        Console.WriteLine("Please enter a valid between 1 and 3.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid between 1 and 3.");
                }
            } 
        }

        public bool BetDidWin()
        {
            var number = SpinWheel();

            List<string> columnOne = new List<string> {"1", "4", "7", "10", "13", "16", "19", "22", "25", "28", "31", "34"};
            List<string> columnTwo = new List<string> {"2", "5", "8", "11", "14", "17", "20", "23", "26", "29", "32", "35"};
            List<string> columnThree = new List<string> {"3", "6", "9", "12", "15", "18", "21", "24", "27", "30", "33", "36"};

            if (BetByColumns == 1)
            {
                if (columnOne.Contains(number.number))
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
                if (columnTwo.Contains(number.number))
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
                if (columnThree.Contains(number.number))
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
