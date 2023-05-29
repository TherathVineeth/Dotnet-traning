using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            for(int i=0; i< 4;i++)
            {
                Console.Write(s[0]);
                Console.Write(s[1]);
            }
            Console.WriteLine();
        }
    }
}
