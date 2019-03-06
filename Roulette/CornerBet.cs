using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class CornerBet : IPlayerBet
    {
        bool result;
        int cbNumOne;
        int cbNumTwo;
        int cbNumThree;
        int cbNumFour;
        int[] cbNums = new int[4];

        public CornerBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which numbers do you wish to place a corner bet on? Numbers must be connected horizontally and vertically.\nEX: 1, 2, 4 and 5 | 25, 26, 28 and 29.");
            Console.WriteLine("Enter the first number.");
            cbNumOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            cbNumTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number.");
            cbNumThree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number.");
            cbNumFour = int.Parse(Console.ReadLine());
        }

        public bool BetDidWin()
        {
            RouletteWheel num = new RouletteWheel();
            var number = num.SpinWheel();
            int[] cbNums = { cbNumOne, cbNumTwo, cbNumThree, cbNumFour };

            if (cbNums.Contains(number.value))
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
