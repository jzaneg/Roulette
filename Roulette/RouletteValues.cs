using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class RouletteValues 
    {
        public string number { get; set; }
        public string color { get; set; }

        public RouletteValues(string number, string color)
        {
            this.number = number;
            this.color = color;
        }
        public override string ToString()
        {
            return this.number + " " + this.color;
        }
    }
}
