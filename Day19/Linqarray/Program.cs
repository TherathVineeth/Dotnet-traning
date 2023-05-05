using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dailya","rose","lotus","lilly","hybiscus" };
            var item = from flower in flowers where flower.StartsWith("d") select flower;
            foreach(string f in item)
            {
                Console.WriteLine(f);
            }

            var it = from flow in flowers let len = flow.Length where len>4 select flow;
            foreach (string f in it)
            {
                Console.WriteLine(f);
            }
        }
    }
}
