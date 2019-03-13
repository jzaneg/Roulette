using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class CornerBet : RouletteWheel, IPlayerBet
    {
        bool result;
        string cbNumOne;
        string cbNumTwo;
        string cbNumThree;
        string cbNumFour;
        string[] cbNums = new string[4];

        public CornerBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which numbers do you wish to place a corner bet on? Numbers must be connected horizontally and vertically.\nEX: 1, 2, 4 and 5 | 25, 26, 28 and 29.");
            Console.WriteLine("Enter the first number.");
            cbNumOne = Console.ReadLine();
            Console.WriteLine("Enter the second number.");
            cbNumTwo = Console.ReadLine();
            Console.WriteLine("Enter the third number.");
            cbNumThree = Console.ReadLine();
            Console.WriteLine("Enter the fourth number.");
            cbNumFour = Console.ReadLine();
        }

        public bool BetDidWin()
        {
            var number = SpinWheel();

            string[] cbNums = { cbNumOne, cbNumTwo, cbNumThree, cbNumFour };

            if (cbNums.Contains(number.number))
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
