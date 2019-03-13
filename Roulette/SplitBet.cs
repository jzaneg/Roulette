using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class SplitBet : RouletteWheel, IPlayerBet
    {
        bool result;
        string sbNumOne;
        string sbNumTwo;

        public SplitBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which numbers do you wish to bet a split on? Bet must be on two horizontally or vertically connnected numbers.\nEX: 1&2, 25&28.");
            Console.WriteLine("Enter the first number.");
            sbNumOne = Console.ReadLine();
            Console.WriteLine("Enter the second number.");
            sbNumTwo = Console.ReadLine();
        }

        public bool BetDidWin()
        {
            var number = SpinWheel();

            if (sbNumOne.Equals(number.number) || sbNumTwo.Equals(number.number))
            {
                Console.WriteLine("Congrats! You've Won!");
                result = true;
            }
            else
            {
                Console.WriteLine("I'm sorry, your bet lost.");
                result = false;
            }
            return result;
        }
    }
}
