﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class NumberBet : IPlayerBet
    {
        int numBet;
        bool result;

        public NumberBet()
        {
            PlaceBet();
            BetDidWin();
        }
        public void PlaceBet()
        {
            Console.WriteLine("Which number do you wish to bet on?");
            numBet = int.Parse(Console.ReadLine());
        }
        
        public bool BetDidWin()
        {
            RouletteWheel num = new RouletteWheel();

            if (numBet.Equals(num))
            {
               Console.WriteLine("Congrats! You've Won!");
               result = true;
            }
            else if (!numBet.Equals(num))
            {
                Console.WriteLine("I'm sorry, your bet lost.");
                result = false;
            }
            return result;
        }
    }
}