using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class SplitBet : IPlayerBet
    {
        bool result;
        int sbNumOne;
        int sbNumTwo;

        public SplitBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which numbers do you wish to bet a split on? Bet must be on two horizontally or vertically connnected numbers.\nEX: 1&2, 25&28.");
            Console.WriteLine("Enter the first number.");
            sbNumOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            sbNumTwo = int.Parse(Console.ReadLine());
        }

        public bool BetDidWin()
        {
            RouletteWheel num = new RouletteWheel();
            var number = num.SpinWheel();

            if (sbNumOne.Equals(number.value) || sbNumTwo.Equals(number.value))
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
