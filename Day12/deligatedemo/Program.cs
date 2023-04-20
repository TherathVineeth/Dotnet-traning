using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deligatedemo
{
    internal class Program
    {
        static void Add(int i, int j)
        {
            Console.WriteLine( "sum "+i+j);
        }
        static void Sub(int i , int j)
        {
            Console.WriteLine("sub " + (i-j));
        }
        public delegate void reftomethod(int i, int j);
        static void Main(string[] args)
        {
            reftomethod multicast = Add;
            multicast += Sub;
            multicast(20, 10);
        }
    }
}
