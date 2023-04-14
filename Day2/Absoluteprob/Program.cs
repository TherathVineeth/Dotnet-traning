using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absoluteprob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x :");
            int x = int.Parse(Console.ReadLine());
            int ans = Absu(x);
            Console.WriteLine(ans);
        }

        private static int Absu(int x)
        {
            int e = Math.Abs(x - 51);
            if (x > 51)
            {
               
                return e*3;
            }
            else
            {
                return e; 
            }
        }
    }
}
