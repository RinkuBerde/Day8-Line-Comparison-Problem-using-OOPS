using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Line_Comparison_Problem_using_OOPS
{
    internal class FindLength
    {
        public int x1, x2, y1, y2;
       
        public FindLength(int x1, int x2, int y1, int y2)
        {

            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public double FindingLength()
        {
            //Calculating a line length

            double LineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double len = Math.Round(LineLength, 2);
            return len;

        }
    }
}
