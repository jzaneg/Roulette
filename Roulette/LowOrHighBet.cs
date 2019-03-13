using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class LowOrHighBet : RouletteWheel, IPlayerBet
    {
        char LowHighBet;
        bool result;

        public LowOrHighBet() 
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Do you want to bet on low numbers (1 - 18) or high numbers (19 - 38)?\nPress 'l' for low or 'h' for high.");
            LowHighBet = char.Parse(Console.ReadLine());
        }

        public bool BetDidWin()
        {
            var lowBet = tiles.Skip(2).Take(18).ToList();
            var highBet = tiles.Skip(20).Take(18).ToList();
            
            var number = SpinWheel();
            
            if (LowHighBet == 'l')
            {
                
                if (lowBet.Contains(number))
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
            else if (LowHighBet == 'h')
            {
               
                if (highBet.Contains(number))
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
