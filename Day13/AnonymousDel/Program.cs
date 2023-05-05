using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//delegate int CountIt(int x, int y);

namespace AnonymousDel
{
    internal class Program
    {
        public delegate int Sum(int x, int y);
       
        static void Main(string[] args)
        {

            int result;
            CountIt count = delegate (int x, int y)
            {
                return x + y;
            };

            result = count(10, 30);
            Console.WriteLine(result);  
        }
    }
}
