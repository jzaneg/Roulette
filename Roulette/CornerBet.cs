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
        int cbNumOne = 0;
        int cbNumTwo = 0;
        int cbNumThree = 0;
        int cbNumFour = 0;

        public CornerBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which numbers do you wish to place a corner bet on? Numbers must be connected horizontally and vertically.\nEX: 1, 2, 4 and 5 | 25, 26, 28 and 29.");
            Console.WriteLine("Enter the first number.");
            while (cbNumOne < 1 || cbNumOne > 36)
            {
                try
                {
                    cbNumOne = int.Parse(Console.ReadLine());
                    if (cbNumOne < 1 || cbNumOne > 3)
                    {
                        Console.WriteLine("Please enter a valid between 1 and 36.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid between 1 and 36.");
                }
            }
            Console.WriteLine("Enter the second number.");
            while (cbNumTwo < 1 || cbNumTwo > 36 || cbNumTwo == cbNumOne)
            {
                try
                {
                    cbNumTwo = int.Parse(Console.ReadLine());
                    if (cbNumTwo < 1 || cbNumTwo > 3 || cbNumTwo == cbNumOne)
                    {
                        Console.WriteLine("Please enter a valid between 1 and 36.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid between 1 and 36.");
                }
            }
            Console.WriteLine("Enter the third number.");
            while (cbNumThree < 1 || cbNumThree > 36 || cbNumThree == cbNumOne || cbNumThree == cbNumTwo)
            {
                try
                {
                    cbNumThree = int.Parse(Console.ReadLine());
                    if (cbNumThree < 1 || cbNumThree > 3 || cbNumThree == cbNumOne || cbNumThree == cbNumTwo)
                    {
                        Console.WriteLine("Please enter a valid between 1 and 36.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid between 1 and 36.");
                }
            }
            Console.WriteLine("Enter the fourth number.");
            while (cbNumFour < 1 || cbNumFour > 36 || cbNumFour == cbNumOne || cbNumFour == cbNumTwo || cbNumFour == cbNumThree)
            {
                try
                {
                    cbNumFour = int.Parse(Console.ReadLine());
                    if (cbNumFour < 1 || cbNumFour > 36 || cbNumFour == cbNumOne || cbNumFour == cbNumTwo || cbNumFour == cbNumThree)
                    {
                        Console.WriteLine("Please enter a valid between 1 and 36.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid between 1 and 36.");
                }
            }
        }

        public bool BetDidWin()
        {
            var number = SpinWheel();

            string[] cbNums = new string[4] { cbNumOne.ToString(), cbNumTwo.ToString(), cbNumThree.ToString(), cbNumFour.ToString() };

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
