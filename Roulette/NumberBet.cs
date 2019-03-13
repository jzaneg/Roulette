using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class NumberBet : RouletteWheel, IPlayerBet
    {
        string numBet;
        bool result;

        string[] rouletteNumbers = new string[]
        {"1", "2", "3", "4", "5", "6", "7", "8", "9",
        "10", "11", "12", "13", "14", "15", "16", "17", "18",
        "19", "20", "21", "22", "23", "24","25", "26", "27",
        "28", "29", "30", "31", "32","33", "35", "36", "0", "00"};

        public NumberBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which number do you wish to bet on?");
            numBet = string.Empty;

            while (!rouletteNumbers.Contains(numBet))
            {
                try
                {
                    numBet = Console.ReadLine();
                    if (!rouletteNumbers.Contains(numBet))
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
        }
        
        public bool BetDidWin()
        {
            var number = SpinWheel();
            
            if (numBet.Equals(number.number))
            {
               Console.WriteLine("Congrats! You've Won!");
               result = true;
            }
            else if (!numBet.Equals(number.number)) // <== Not Necessary
            {
                Console.WriteLine("I'm sorry, your bet lost.");
                result = false;
            }
            return result;
        }
    }
}
