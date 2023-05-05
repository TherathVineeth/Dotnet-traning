using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add(1, 2);
            s.Add(3, 4);
            s.Add(5, 6);
            s.Add(6, 7);
            s.Add(7, 8);
            foreach (var item in s.Keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
