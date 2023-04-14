using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of values:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] =int.Parse(Console.ReadLine());
            }
            selection(arr);

        }

        public static void selection(int[] arr)
        {
            for(int i =0;i < arr.Length-1; i++)
            {
                int ind = i;
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[ind])
                    {
                        ind = j;
                        
                    }
                    int temp = arr[ind];
                    arr[ind] = arr[i];
                    arr[i] = temp;
                }
               
            }
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
