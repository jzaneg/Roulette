using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class EvenOrOddBet : RouletteWheel, IPlayerBet
    {
        char EvenOddBet;
        bool result;

        public EvenOrOddBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Do you want to bet on evens or odds?\nPress 'e' for evens or 'o' for odds.");
            EvenOddBet = char.Parse(Console.ReadLine());
        }

        public bool BetDidWin() 
        {
            var number = SpinWheel();

            List<string> evens = new List<string> { "2", "4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36" };
            List<string> odds = new List<string> { "1", "3", "5", "7", "9", "11", "13", "15", "17", "19", "21", "23", "25", "27", "29", "31", "33", "35" };

            if (EvenOddBet == 'e')
            {
                if (evens.Contains(number.number)) //<== num is even
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
            else if (EvenOddBet == 'o')
            {
                if (odds.Contains(number.number))//<== num is odd
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
