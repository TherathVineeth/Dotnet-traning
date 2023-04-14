using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notesrequired
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount:");
            int amount = int.Parse(Console.ReadLine());
            int[] ints = { 2000, 500,200, 100, 50, 20, 10, 5, 2, 1 };

            int i = 0;
            while(amount>0)
            {
                Console.WriteLine((amount/ints[i])+$" Number of {ints[i]} is required ");
                amount %= ints[i];
                i++;
            }
        }
    }
}
