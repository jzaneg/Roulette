using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class EvenOrOddBet : IPlayerBet
    {
        char EvenOddBet;
        bool result;
        //int evenBet;
        //int oddBet;

        public EvenOrOddBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Do you want to bet on evens or odds?\nPress 'e' for evens or 'o' for odds.");
            EvenOddBet = char.Parse(Console.ReadLine());
        }

        public bool BetDidWin() 
        {
            
            RouletteWheel num = new RouletteWheel();
            Number number = num.SpinWheel();
           
            if (EvenOddBet == 'e')
            {
                if (number.value % 2 == 0) //<== num is even
                {
                    Console.WriteLine("Congrats! You've Won!");
                    result = true;
                }
                else if (number.value % 2 != 0)//<== num is odd
                {
                    Console.WriteLine("I'm sorry, your bet lost.");
                    result = false;
                }
            }
            else if (EvenOddBet == 'o')
            {
                if (number.value % 2 != 0)//<== num is odd
                {
                    Console.WriteLine("Congrats! You've Won!");
                    result = true;
                }
                else if (number.value % 2 == 0)//<== num is even
                {
                    Console.WriteLine("I'm sorry, your bet lost.");
                    result = false;
                }
            }
            return result;
        }
    }
}
//DI
//public controller(SqlConnection sqlconnection
//{
//  m_connection = sqlconnection;
//}
