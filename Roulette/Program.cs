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
            
            Console.WriteLine("Please choose an option:\n1:Spin the wheel\n2:Bet a number\n3:Bet Red or Black\n4:Bet Evens/Odds\n5:Bet Lows/Highs\n6:Bet Dozens\n7:Bet Columns\n8:Bet Streets\n9:Bet Double Rows (6 numbers)\n10:Bet Split\n11:Bet Corners");

            int playerChoice = int.Parse(Console.ReadLine());
            switch(playerChoice)
            {
                case 1: //<== Is equivalent to using if  playerchoice == 1 do this.
                    RouletteWheel rw = new RouletteWheel();
                    break;
                case 2:
                    NumberBet nb = new NumberBet();
                    break;
                case 3:
                    RedOrBlackBet rb = new RedOrBlackBet();
                    break;
                case 4:
                    EvenOrOddBet eob = new EvenOrOddBet();
                    break;
                case 5:
                    LowOrHighBet lhb = new LowOrHighBet();
                    break;
                case 6:
                    DozensBet db = new DozensBet();
                    break;
                case 7:
                    ColumnBet cb = new ColumnBet();
                    break;
                case 8:
                    StreetBet sb = new StreetBet();
                    break;
                case 9:
                    DoubleStreet ds = new DoubleStreet();
                    break;
                case 10:
                    SplitBet splb = new SplitBet();
                    break;
                case 11:
                    CornerBet cnrb = new CornerBet();
                    break;
            }
            Console.ReadKey();
        }
    }
}
//TODO
// Validation checks for all classes.
// Return to start to play again feature
//incorporate monetary variable to play?
//
