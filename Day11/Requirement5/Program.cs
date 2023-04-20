using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    internal class Program
    {
        static void Main(string[] args)
        {

          ArrayList arrayList = new ArrayList();
            Console.WriteLine("Enter the number of members");
            int n = int.Parse(Console.ReadLine());
            
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Member " + i+1);
                    string s = Console.ReadLine();
                    string[] arr = s.Split(',');
                   // DateTime dt1 = DateTime.Parse(arr[5]);
                   // DateTime dt = DateTime.Parse(arr[6]);
                    Member member = new Member(int.Parse(arr[0]), arr[1], arr[2], arr[3], arr[4], arr[5]);
                try
                {
                    member.checking(arr[3]);
                }
                catch (InvalidEmailException e)
                {
                   e.inform();
                }
                arrayList.Add(member);
                

            }
            Console.WriteLine("The Members are");
            foreach (Member m in arrayList)
            {
                Console.WriteLine(m.ToString());
            }
        }
    }
}
