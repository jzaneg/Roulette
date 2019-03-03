using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class StreetBet : IPlayerBet
    {
        int BetByStreets;
        bool result;

        public StreetBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which street do you want to bet on?\nPress the number indicating your bet.\n1: numbers 1, 2, and 3.\n2: numbers 4, 5, and 6.\n3: numbers 7, 8, and 9\n4: numbers 10, 11, and 12.\n" +
                              "5: numbers 13, 14, and 15.\n6: numbers 16, 17, and 18.\n7: numbers 19, 20, and 21.\n8: numbers 22, 23, and 24.\n9: numbers 25, 26, and 27.\n10: numbers 28, 29, and 30.\n11: numbers 31, 32, and 33.\n" +
                              "12: numbers 34, 35, and 36");
            BetByStreets = int.Parse(Console.ReadLine());
        }

        public bool BetDidWin()
        {
            RouletteWheel num = new RouletteWheel();
            var number = num.SpinWheel();
            List<int> streetOne = new List<int> {1, 2, 3};
            List<int> streetTwo = new List<int> {4, 5, 6};
            List<int> streetThree = new List<int> {7, 8, 9};
            List<int> streetFour = new List<int> {10, 11, 12};
            List<int> streetFive = new List<int> {13, 14, 15};
            List<int> streetSix = new List<int> {16, 17, 18};
            List<int> streetSeven = new List<int> {19, 20, 21};
            List<int> streetEight = new List<int> {22, 23, 24};
            List<int> streetNine = new List<int> {25, 26, 27};
            List<int> streetTen = new List<int> {28, 29, 30};
            List<int> streetEleven = new List<int> {31, 32, 33};
            List<int> streetTwelve = new List<int> {34, 35,36};

            switch (BetByStreets)
            {
                case 1:
                    if (streetOne.Contains(number.value))
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
                    if (streetTwo.Contains(number.value))
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
                    if (streetThree.Contains(number.value))
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
                    if (streetFour.Contains(number.value))
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
                    if (streetFive.Contains(number.value))
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
                    if (streetSix.Contains(number.value))
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
                    if (streetSeven.Contains(number.value))
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
                    if (streetEight.Contains(number.value))
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
                    if (streetNine.Contains(number.value))
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
                    if (streetTen.Contains(number.value))
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
                    if (streetEleven.Contains(number.value))
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
                case 12:
                    if (streetTwelve.Contains(number.value))
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
