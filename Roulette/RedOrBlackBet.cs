using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class RedOrBlackBet : RouletteWheel, IPlayerBet
    {
        int colorBet;
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
            colorBet = int.Parse(Console.ReadLine());
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
