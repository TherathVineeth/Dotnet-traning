
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1 :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number 2:");
            int y = int.Parse(Console.ReadLine());  
            fool(x,y);
            Console.WriteLine("debugging over");
        }

        private static void fool(int x, int y)
        {
            int t = 100;
            for(int i = x; i < y ; i++)
            {
                Console.WriteLine("India");
                t = t + 34;
            }
        }
    }
}
