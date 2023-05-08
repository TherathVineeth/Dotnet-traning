using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //using (var context = new ClientEntities())
            //{
            //    var std = new CLIENT_MASTER()
            //    {
            //        CLIENTNO = "1002",
            //        NAME = "Deera",
            //        ADDRESS1 = "Chennai",
            //        ADDRESS2 = "Kanyakumarai",
            //        CITY = "thuckalay",
            //        PINCODE = 629164,
            //        Phone_no = "12345689"
            //    };
            //    context.CLIENT_MASTER.Add(std);

            //    context.SaveChanges();
            //}
            using (var context = new ClientEntities())
            {
                var std = context.CLIENT_MASTER.FirstOrDefault<CLIENT_MASTER>();
                std.NAME = "Therath";
                context.SaveChanges();
            }

            ClientEntities clientEntities = new ClientEntities();
            foreach(var item in clientEntities.CLIENT_MASTER)
            {
                Console.WriteLine(item.ADDRESS1);
            }
        }
    }
}
