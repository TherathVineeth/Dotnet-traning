using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointer
{
    internal class Program
    {
        static unsafe void Main(string[] args)
        {
            int val = 50;
            int* x = &val;

            Console.WriteLine("Data: {0} ", val);
            Console.WriteLine("Address: {0}", (long)x);
            Console.ReadKey();
        }
    }
}
