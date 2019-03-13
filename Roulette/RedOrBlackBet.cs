using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class RedOrBlackBet : RouletteWheel, IPlayerBet
    {
        int colorBet = 0;
        string betColor;
        bool result;

        public RedOrBlackBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which color do you wish to bet on?\nPress 1 for Red or 2 for Black.");
            while (colorBet < 1 || colorBet > 2)
            {
                try
                {
                    colorBet = int.Parse(Console.ReadLine());
                    if (colorBet < 1 || colorBet > 2)
                    {
                        Console.WriteLine("Please enter either 1 to bet Red or 2 to bet Black.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter either 1 to bet Red or 2 to bet Black.");
                }
            }
        }

        public bool BetDidWin()
        {
            var color = SpinWheel();


            if (colorBet == 1)
            {
                betColor = "red";
            }
            else if (colorBet == 2)
            {
                betColor = "black";
            }

            if (betColor.Equals(color.color))
            {
                Console.WriteLine("Congrats! You've Won!");
                result = true;
            }
            else if (!betColor.Equals(color.color)) // <== Not Necessary
            {
                Console.WriteLine("I'm sorry, your bet lost.");
                result = false;
            }
            return result;
        }
    }
}
