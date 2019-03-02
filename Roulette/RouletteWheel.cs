using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class RouletteWheel 
    {
        public List<Number> tiles = new List<Number>();

        public RouletteWheel()
        {
            InitializeBoard();
            Console.WriteLine("Wheel spinning......");
            Console.WriteLine($"The ball landed on: {SpinWheel()}"); //<= Only if user enters 0 to spin wheel.
        }

        public Number SpinWheel()
        {
            Random rdm = new Random();
            int spin = rdm.Next() % tiles.Count;
            return tiles.ElementAt(spin);
        }

        public void InitializeBoard()
        {
            tiles.Add(new Number(00, "green"));
            tiles.Add(new Number(0, "green"));
            tiles.Add(new Number(1, "red"));
            tiles.Add(new Number(2, "black"));
            tiles.Add(new Number(3, "red"));
            tiles.Add(new Number(4, "black"));
            tiles.Add(new Number(5, "red"));
            tiles.Add(new Number(6, "black"));
            tiles.Add(new Number(7, "red"));
            tiles.Add(new Number(8, "black"));
            tiles.Add(new Number(9, "red"));
            tiles.Add(new Number(10, "black"));
            tiles.Add(new Number(11, "black"));
            tiles.Add(new Number(12, "red"));
            tiles.Add(new Number(13, "black"));
            tiles.Add(new Number(14, "red"));
            tiles.Add(new Number(15, "black"));
            tiles.Add(new Number(16, "red"));
            tiles.Add(new Number(17, "black"));
            tiles.Add(new Number(18, "red"));
            tiles.Add(new Number(19, "red"));
            tiles.Add(new Number(20, "black"));
            tiles.Add(new Number(21, "red"));
            tiles.Add(new Number(22, "black"));
            tiles.Add(new Number(23, "red"));
            tiles.Add(new Number(24, "black"));
            tiles.Add(new Number(25, "red"));
            tiles.Add(new Number(26, "black"));
            tiles.Add(new Number(27, "red"));
            tiles.Add(new Number(28, "black"));
            tiles.Add(new Number(29, "black"));
            tiles.Add(new Number(30, "red"));
            tiles.Add(new Number(31, "black"));
            tiles.Add(new Number(32, "red"));
            tiles.Add(new Number(33, "black"));
            tiles.Add(new Number(34, "red"));
            tiles.Add(new Number(35, "black"));
            tiles.Add(new Number(36, "red"));
            
        }
        //public static void SpinWheel()
        //{
        //    int[] wheelNums = {00, 0, 1, 2, 3, 4, 5, 6,
        //                       7, 8, 9, 10, 11, 12, 13, 14,
        //                       15, 16, 17, 18, 19, 20, 21, 22,
        //                       23, 24, 25, 26, 27, 28, 29, 30,
        //                       31, 32, 33, 34, 35, 36, 37, 38};
        //}
    }
}

