using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Line_Comparison_Problem_using_OOPS
{
    internal class CheckEquality
    {
        public int x1, x2, y1, y2;

        public CheckEquality(int x1, int x2, int y1, int y2)
        {

            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public double FindingLength1()
        {
            //Calculating a line length

            double LineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double len = Math.Round(LineLength, 2);
            return len;

        }
            
        public void EqualityMethod(string len1, string len2)
        {   
            //check Equality
            if (len1 == len2)
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }
    }
}
