using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 10,i = 2;
            int[] a = new int[5];

            try
            {
                i = t/i;
                a[10] = 9;
                //Console.WriteLine(t);
                //Console.WriteLine(a[10]);
            }catch (DivideByZeroException e)
            {
                Console.WriteLine("i is the error its zero");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("out of bountory");
            }
            finally
            {
                Console.WriteLine("done");
            }
        }
    }
}
