using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Number 
    {
        public int value { get; set; }
        public string color { get; set; }

        public Number(int num, string color)
        {
            this.value = num;
            this.color = color;
        }
        public override string ToString()
        {
            return this.value + " " + this.color;
        }

        //public bool DidWin(Number num)
        //{
        //    if (player bet == Number/color spun)
        //    {

        //    };
        //}
    }
}
