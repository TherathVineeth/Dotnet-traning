using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speedkm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance :");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time to be taken :");
            double t = double.Parse(Console.ReadLine());    
            double km = Calkm(d, t);
            Console.WriteLine($"The speed in km is :{km} ");
            double miles = mil(d);
            Console.WriteLine($"The miles per hour is : {miles}");
        }

        private static double mil(double d)
        {
            double ans = d * 0.62137;
            return ans;
        }

        private static Double Calkm(double d, double t)
        {
            double ab = d / t;
            return ab;
        }
    }
}
