using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Linqdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

            var b = from s in a  select s;
            foreach ( var s in b )
            {
                Console.WriteLine(s);
            }
        }
    }
}
