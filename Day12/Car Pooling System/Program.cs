using Car_Pooling_System.Requirement_1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Pooling_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> ls = new List<Member>();

            for(int i=0;i<2;i++)
            {
                Console.WriteLine($"Member{i+1}");
                Console.WriteLine("Id:");
                int id = int.Parse( Console.ReadLine() );
                Console.WriteLine("first name");
                string firstname = Console.ReadLine();
                Console.WriteLine("last name");
                string lastname = Console.ReadLine();
                Console.WriteLine("email:");
                string email = Console.ReadLine();
                Console.WriteLine("contact number");
                string contactnumber = Console.ReadLine();
                Console.WriteLine("license number");
                string licensenumber = Console.ReadLine();
                Console.WriteLine("license start date");
                DateTime licensestart = DateTime.Parse( Console.ReadLine() );
                Console.WriteLine("License end date");
                DateTime licenseend = DateTime.Parse( Console.ReadLine() );
                Member member = new Member(id,firstname,lastname,email,contactnumber,licensenumber,licensestart,licenseend);
                ls.Add(member);
                
            }
            foreach (Member m in ls)
            {
                Console.WriteLine(m.ToString());
            }
            if (ls[0].Equals(ls[1]))
            {
                Console.WriteLine("Member1 is same as Member 2");
            }
            else
            {
                Console.WriteLine("Member 1 and Member 2 are different");
            }
        }
    }
}
