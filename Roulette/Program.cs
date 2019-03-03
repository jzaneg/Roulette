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
            
            Console.WriteLine("Please choose an option:\n1:Spin the wheel\n2:Bet a number\n3:Bet Evens/Odds\n4:Bet Lows/Highs\n5:Bet Dozens\n6:Bet Columns\n7:Bet Streets\n8:Bet Double Rows (6 numbers)\n9:Bet Split\n10:Bet Corners");

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
                    EvenOrOddBet eob = new EvenOrOddBet();
                    break;
                case 4:
                    LowOrHighBet lhb = new LowOrHighBet();
                    break;
                case 5:
                    DozensBet db = new DozensBet();
                    break;
                case 6:
                    ColumnBet cb = new ColumnBet();
                    break;
                case 7:
                    StreetBet sb = new StreetBet();
                    break;
            }
            Console.ReadKey();
        }
    }
}
