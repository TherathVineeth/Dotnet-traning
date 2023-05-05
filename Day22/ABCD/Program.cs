using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<emp> e = new List<emp>();

            e.Add(new emp ("Hari","chennai"));
            e.Add(new emp ("susil","madurai"));
            e.Add(new emp ("Akhil","Banglore"));
            e.Add(new emp ("Ram","Kerala"));
            e.Add(new emp ("Rahul","chennai"));
            e.Add(new emp ("Mohan","Goa"));
            e.Add(new emp ("Karthik","Sikkim"));
            e.Add(new emp ("Keerthana","Maharashtra"));
            
            
            var item = from emp a in e orderby a._place group a by a._place;
            foreach(var p in item)
            {
                Console.WriteLine("Employee with "+p.Key+"  City");
                foreach(var c in p)
                {
                    Console.WriteLine("   " + c._name);
                }
            }

        }
    }
}
