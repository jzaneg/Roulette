using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {

        static void Main(string[] args)
        {
            playRoulette();
        }

        public static void playRoulette()
        {
            Console.WriteLine("Welcome to Roulette. Please place your bet.");
            Console.WriteLine("Please choose an option:\n1:Spin the wheel\n2:Bet a number\n3:Bet Red or Black\n4:Bet Evens/Odds\n5:Bet Lows/Highs\n6:Bet Dozens\n7:Bet Columns\n8:Bet Streets\n9:Bet Double Rows (6 numbers)\n10:Bet Split\n11:Bet Corners\n12: Quit Playing");
            
            int playerChoice = 0;
            while (playerChoice < 1 || playerChoice > 12)
            {
                try
                {
                    playerChoice = int.Parse(Console.ReadLine());
                    switch (playerChoice)
                    {
                    case 1: //<== Is equivalent to using if  playerchoice == 1 do this.
                        RouletteWheel rw = new RouletteWheel();
                        Console.WriteLine();
                        playRoulette();
                        break;

                    case 2:
                       NumberBet nb = new NumberBet();
                        Console.WriteLine();

                        playRoulette();
                        break;

                    case 3:
                        RedOrBlackBet rb = new RedOrBlackBet();
                        Console.WriteLine();
                        playRoulette();
                        break;

                    case 4:
                        EvenOrOddBet eob = new EvenOrOddBet();
                        Console.WriteLine();
                        playRoulette();
                        break;

                    case 5:
                        LowOrHighBet lhb = new LowOrHighBet();
                        Console.WriteLine();
                        playRoulette();
                        break;

                    case 6:
                        DozensBet db = new DozensBet();
                        Console.WriteLine();
                        playRoulette();
                        break;

                    case 7:
                        ColumnBet cb = new ColumnBet();
                        Console.WriteLine();
                        playRoulette();
                        break;

                    case 8:
                        StreetBet sb = new StreetBet();
                        Console.WriteLine();
                        playRoulette();
                        break;

                    case 9:
                        DoubleStreet ds = new DoubleStreet();
                        Console.WriteLine();
                        playRoulette();
                        break;

                    case 10:
                        SplitBet splb = new SplitBet();
                        Console.WriteLine();
                        playRoulette();
                        break;

                    case 11:
                        CornerBet cnrb = new CornerBet();
                        Console.WriteLine();
                        playRoulette();
                        break;

                    case 12:
                        break;
                    }
                    if (playerChoice < 1 || playerChoice > 12)
                    {
                        Console.WriteLine("Please enter a valid number between 1 and 12.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number between 1 and 12.");
                }
            }
        } 
            
    }
}