using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Write a program in C# Sharp
             *  to count a total number of alphabets, digits and 
             *  special characters in a string  */

            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            String(s);

        }

        private static void String(string s)
        {
            int n = s.Length;
            int count = 0;
            int num = 0;
            int spl = 0;
            for(int i=0; i < n; i++)
            {
                if (((s[i] >= 'a') && (s[i] <= 'z')) || ((s[i] >= 'A') && (s[i] <= 'Z')))
                {
                    count++;
                } 
                else if((s[i] >='0') && (s[i] <= '9'))
                {
                    num++;
                }
                else
                {
                    spl++;
                }

            }

            Console.WriteLine($"Number of alphabets in string : {count}");
            Console.WriteLine($"Count of numbers in given string: {num}");
            Console.WriteLine($"Number of special char : {spl}");

        }
    }
}
