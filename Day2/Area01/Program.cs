using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius :"); 
            double r = double.Parse(Console.ReadLine());   // getting input

            double ans = Area(r);   // call the function
            Console.WriteLine("Area of circle is = " + ans);     //output
        }

        public static double Area(double r)
        {
         
             double q = 3.14 * r * r;
            return q;
        }
    }
}
