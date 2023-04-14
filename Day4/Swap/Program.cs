using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("number 2");
            int n2 = int.Parse(Console.ReadLine());
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
    }
}
