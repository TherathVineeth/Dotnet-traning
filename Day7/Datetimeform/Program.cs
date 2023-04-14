using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetimeform
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DateTime dt0 = new DateTime(2000,03,29,05,30,00);
              
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToShortTimeString()); 
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToLongTimeString());

            // above formate using long and sort

            /// UTC TIME  COORDINATE UNIVERSAL TIME
             
            DateTime dt1 = DateTime.UtcNow;
            Console.WriteLine(dt1);

            // min max in datetime;

            DateTime dt3 = DateTime.MinValue;
            Console.WriteLine(dt3);
            DateTime dt4 = DateTime.MaxValue;
            Console.WriteLine(dt4);

            // time span

            TimeSpan timeSpan = new TimeSpan(1,0,0,0);
            DateTime dt5 = DateTime.Now.Add(timeSpan); // add an extra days
            Console.WriteLine(dt5);

            // to add directely

            Console.WriteLine(dt5.AddDays(9));
          //  Console.WriteLine(dt4.AddMonths(3));

            // Day of week and dayof year 

            Console.WriteLine(dt.DayOfYear);
            Console.WriteLine(dt.DayOfWeek);


            // Datetime formating

            Console.WriteLine(dt.ToString("yyyy MM dd : hh mm ss "));


            // to compare dates 

            var result = DateTime.Compare(dt0, dt);
            Console.WriteLine(result);                   // ------ useless


            // diff dates

            var days = dt0 - dt;
            Console.WriteLine(days.ToString("dd"));

        }
    }
}
