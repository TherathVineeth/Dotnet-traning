using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimaltobinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal value");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[10];

           int i = 0;
            while (n>0) {

               
                arr[i] = n%2;
                i++;
                n = n / 2;

            }
            // Array.Reverse(arr);
            while(i>0)
            {
                Console.Write(arr[i]+" ");
                i--;
            }
        }
    }
}
