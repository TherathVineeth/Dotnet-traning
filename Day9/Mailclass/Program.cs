using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mail mail = null;

            //mail = new Mail();
            Console.WriteLine("Enter mail 1 details:");
            string m1 = Console.ReadLine();
            Console.WriteLine("Enter mail 2 details");
            string m2 = Console.ReadLine();
            string[] arr1 = m1.Split(',');
            long id = Convert.ToInt64(arr1[0]);
            string to = Convert.ToString(arr1[1]);
            string from = Convert.ToString(arr1[2]);
            string sub = Convert.ToString(arr1[3]);
            string cont = Convert.ToString(arr1[4]);
            DateTime dt = Convert.ToDateTime(arr1[5]);
            double size = Convert.ToDouble(arr1[6]);
            string[] arr2 = m2.Split(',');
            long id1 = Convert.ToInt64(arr2[0]);
            string to1 = Convert.ToString(arr2[1]);
            string from1 = Convert.ToString(arr2[2]);
            string sub1 = Convert.ToString(arr2[3]);
            string cont1 = Convert.ToString(arr2[4]);
            DateTime dt1 = Convert.ToDateTime(arr2[5]);
            double size1 = Convert.ToDouble(arr2[6]);

            if (arr1[3] == arr2[3] && arr1[1] == arr2[1]&& arr1[2] == arr2[2])
            {
                mail = new Mail(id,to,from,sub,cont,dt,size);
                Console.WriteLine("Mail 1:");
               // mail.Display();
               mail.ToString();
                Console.WriteLine("Mail 2:");
              //  mail.Display();
                Console.WriteLine("Mail 1 and Mail 2 are same ");
            }
            else
            {
                mail = new Mail(id, to, from, sub, cont, dt, size);
                Console.WriteLine("Mail 1:");
              //  mail.Display();
                mail = new Mail(id1, to1, from1, sub1, cont1, dt1, size1);
                Console.WriteLine("Mail 2:");
              //  mail.Display();
                Console.WriteLine("Mail 1 and Mail 2 are Different ");
            }
        }
    }
}
