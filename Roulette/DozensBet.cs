using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class DozensBet : IPlayerBet
    {
        int BetByDozens;
        bool result;

        public DozensBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which set of dozens do you want to bet on? Press '1' for numbers 1 - 12, '2' for numbers 13 - 24, or '3' for numbers 25 - 36.");
            BetByDozens = int.Parse(Console.ReadLine());
        }

        public bool BetDidWin()
        {
            RouletteWheel num = new RouletteWheel();
            var number = num.SpinWheel();
            var firstDozen = num.tiles.Skip(2).Take(12).ToList();
            var secondDozen = num.tiles.Skip(14).Take(12).ToList();
            var thirdDozen = num.tiles.Skip(26).Take(12).ToList();

            if (BetByDozens == 1)
            {
                if (firstDozen.Contains(number))
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
            else if (BetByDozens == 2)
            {
                if (secondDozen.Contains(number))
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
            else if (BetByDozens == 3)
            {
                if (thirdDozen.Contains(number))
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
