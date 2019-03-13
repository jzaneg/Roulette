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
        int sbNumOne = 0;
        int sbNumTwo = 0;

        public SplitBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which numbers do you wish to bet a split on? Bet must be on two horizontally or vertically connnected numbers.\nEX: 1&2, 25&28.");
            Console.WriteLine("Enter the first number.");
            while (sbNumOne < 1 || sbNumOne > 36)
            {
                try
                {
                    sbNumOne = int.Parse(Console.ReadLine());
                    if (sbNumOne < 1 || sbNumOne > 36)
                    {
                        Console.WriteLine("Please enter a number between 1 and 35.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number between 1 and 35.");
                }
            }
            
            Console.WriteLine("Enter the second number.");
            while (sbNumTwo < 1 || sbNumTwo > 36)
            {
                try
                {
                    sbNumTwo = int.Parse(Console.ReadLine());
                    if (sbNumTwo < 1 || sbNumTwo > 36)
                    {
                        Console.WriteLine("Please enter a number between 1 and 35.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number between 1 and 35.");
                }
            }
            
        }

        public bool BetDidWin()
        {
            var number = SpinWheel();
            if (number.number == sbNumOne.ToString() || number.number == sbNumTwo.ToString())
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
