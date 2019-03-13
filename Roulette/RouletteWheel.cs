using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class RouletteWheel 
    {
        public List<RouletteValues> tiles = new List<RouletteValues>();

        public RouletteWheel()
        {
            InitializeBoard();
        }

        public RouletteValues SpinWheel()
        {
            Random rdm = new Random();
            int spin = rdm.Next() % tiles.Count;
            var spinValues = tiles.ElementAt(spin);
            Console.WriteLine("Wheel spinning......");
            Console.WriteLine($"The ball landed on: {spinValues}"); //<= Only if user enters 0 to spin wheel.
            return spinValues;
        }

        public void InitializeBoard()
        {
            tiles.Add(new RouletteValues("00", "green"));
            tiles.Add(new RouletteValues("0", "green"));
            tiles.Add(new RouletteValues("1", "red"));
            tiles.Add(new RouletteValues("2", "black"));
            tiles.Add(new RouletteValues("3", "red"));
            tiles.Add(new RouletteValues("4", "black"));
            tiles.Add(new RouletteValues("5", "red"));
            tiles.Add(new RouletteValues("6", "black"));
            tiles.Add(new RouletteValues("7", "red"));
            tiles.Add(new RouletteValues("8", "black"));
            tiles.Add(new RouletteValues("9", "red"));
            tiles.Add(new RouletteValues("10", "black"));
            tiles.Add(new RouletteValues("11", "black"));
            tiles.Add(new RouletteValues("12", "red"));
            tiles.Add(new RouletteValues("13", "black"));
            tiles.Add(new RouletteValues("14", "red"));
            tiles.Add(new RouletteValues("15", "black"));
            tiles.Add(new RouletteValues("16", "red"));
            tiles.Add(new RouletteValues("17", "black"));
            tiles.Add(new RouletteValues("18", "red"));
            tiles.Add(new RouletteValues("19", "red"));
            tiles.Add(new RouletteValues("20", "black"));
            tiles.Add(new RouletteValues("21", "red"));
            tiles.Add(new RouletteValues("22", "black"));
            tiles.Add(new RouletteValues("23", "red"));
            tiles.Add(new RouletteValues("24", "black"));
            tiles.Add(new RouletteValues("25", "red"));
            tiles.Add(new RouletteValues("26", "black"));
            tiles.Add(new RouletteValues("27", "red"));
            tiles.Add(new RouletteValues("28", "black"));
            tiles.Add(new RouletteValues("29", "black"));
            tiles.Add(new RouletteValues("30", "red"));
            tiles.Add(new RouletteValues("31", "black"));
            tiles.Add(new RouletteValues("32", "red"));
            tiles.Add(new RouletteValues("33", "black"));
            tiles.Add(new RouletteValues("34", "red"));
            tiles.Add(new RouletteValues("35", "black"));
            tiles.Add(new RouletteValues("36", "red"));
        }
    }
}

