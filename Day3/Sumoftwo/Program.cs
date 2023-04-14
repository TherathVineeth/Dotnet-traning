using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumoftwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first value :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second value :");
            int b = int.Parse(Console.ReadLine());
            int sum = Sumof(a, b);
            Console.WriteLine(sum);
        }

        private static int Sumof(int a, int b)
        {
            int ans = a+ b;
            if(a == b)
            {
                return ans*3;
            }
            else
            {
                return ans;
            }
        }
    }
}
