using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class DoubleStreet : IPlayerBet
    {
        int BetByDoubleStreets;
        bool result;

        public DoubleStreet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which street doubles do you want to bet on?\nPress the number indicating your bet.\n1: numbers 1 - 6.\n2: numbers 4 -9\n3: numbers 7 - 12\n4: numbers 10 - 15.\n" +
                              "5: numbers 13 - 18.\n6: numbers 16 - 21.\n7: numbers 19 - 24.\n8: numbers 22 - 27.\n9: numbers 25 - 30.\n10: numbers 28 - 33.\n11: numbers 31 - 36." );
            BetByDoubleStreets = int.Parse(Console.ReadLine());
        }

        public bool BetDidWin()
        {
            RouletteWheel num = new RouletteWheel();
            var number = num.SpinWheel();
            List<int> dblStreetOne = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> dblStreetTwo = new List<int> { 4, 5, 6, 7, 8, 9 };
            List<int> dblStreetThree = new List<int> { 7, 8, 9, 10, 11, 12 };
            List<int> dblStreetFour = new List<int> { 10, 11, 12, 13, 14, 15 };
            List<int> dblStreetFive = new List<int> { 13, 14, 15, 16, 17, 18 };
            List<int> dblStreetSix = new List<int> { 16, 17, 18, 19, 20, 21 }; 
            List<int> dblStreetSeven = new List<int> { 19, 20, 21, 22, 23, 24 };
            List<int> dblStreetEight = new List<int> { 22, 23, 24, 25, 26, 27 };
            List<int> dblStreetNine = new List<int> { 25, 26, 27, 28, 29, 30 };
            List<int> dblStreetTen = new List<int> { 28, 29, 30, 31, 32, 33 };
            List<int> dblStreetEleven = new List<int> { 31, 32, 33, 34, 35, 36 };

            switch (BetByDoubleStreets)
            {
                case 1:
                    if (dblStreetOne.Contains(number.value))
                    {
                        Console.WriteLine("Congrats! You've Won!");
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, your bet lost.");
                        result = false;
                    }
                    break;
                case 2:
                    if (dblStreetTwo.Contains(number.value))
                    {
                        Console.WriteLine("Congrats! You've Won!");
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, your bet lost.");
                        result = false;
                    }
                    break;
                case 3:
                    if (dblStreetThree.Contains(number.value))
                    {
                        Console.WriteLine("Congrats! You've Won!");
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, your bet lost.");
                        result = false;
                    }
                    break;
                case 4:
                    if (dblStreetFour.Contains(number.value))
                    {
                        Console.WriteLine("Congrats! You've Won!");
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, your bet lost.");
                        result = false;
                    }
                    break;
                case 5:
                    if (dblStreetFive.Contains(number.value))
                    {
                        Console.WriteLine("Congrats! You've Won!");
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, your bet lost.");
                        result = false;
                    }
                    break;
                case 6:
                    if (dblStreetSix.Contains(number.value))
                    {
                        Console.WriteLine("Congrats! You've Won!");
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, your bet lost.");
                        result = false;
                    }
                    break;
                case 7:
                    if (dblStreetSeven.Contains(number.value))
                    {
                        Console.WriteLine("Congrats! You've Won!");
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, your bet lost.");
                        result = false;
                    }
                    break;
                case 8:
                    if (dblStreetEight.Contains(number.value))
                    {
                        Console.WriteLine("Congrats! You've Won!");
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, your bet lost.");
                        result = false;
                    }
                    break;
                case 9:
                    if (dblStreetNine.Contains(number.value))
                    {
                        Console.WriteLine("Congrats! You've Won!");
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, your bet lost.");
                        result = false;
                    }
                    break;
                case 10:
                    if (dblStreetTen.Contains(number.value))
                    {
                        Console.WriteLine("Congrats! You've Won!");
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, your bet lost.");
                        result = false;
                    }
                    break;
                case 11:
                    if (dblStreetEleven.Contains(number.value))
                    {
                        Console.WriteLine("Congrats! You've Won!");
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, your bet lost.");
                        result = false;
                    }
                    break;
            }
            return result;
        }
    }
}
