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
            Console.WriteLine("Enter the value of x :");  
            //Getting input
            int x = int.Parse(Console.ReadLine());
            //calling function
            int ans = Absu(x);
            //print output
            Console.WriteLine(ans);
        }

        private static int Absu(int x)
        {
            int e = Math.Abs(x - 51);
            if (x > 51)
            {

                return e * 3;
            }
            else
            {
                return e;
            }
        }
    }
    }

