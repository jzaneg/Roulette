using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class DozensBet : RouletteWheel, IPlayerBet
    {
        int BetByDozens = 0;
        bool result;

        public DozensBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which set of dozens do you want to bet on? Press 1, 2, or 3.\n1: numbers 1 - 12.\n2: numbers 13 - 24.\n3: numbers 25 - 36.");
            while (BetByDozens < 1 || BetByDozens > 3)
            {
                try
                {
                    BetByDozens = int.Parse(Console.ReadLine());
                    if (BetByDozens < 1 || BetByDozens > 3)
                    {
                        Console.WriteLine("Please enter a number between 1 and 3.");
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Please enter a valid number between 1 and 3.");
                }
            }
        }

        public bool BetDidWin()
        {
            var number = SpinWheel();

            var firstDozen = tiles.Skip(2).Take(12).ToList();
            var secondDozen = tiles.Skip(14).Take(12).ToList();
            var thirdDozen = tiles.Skip(26).Take(12).ToList();

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
