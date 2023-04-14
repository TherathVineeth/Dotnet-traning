using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeedetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the employe name :");
            String name = Console.ReadLine();
            Console.WriteLine("Enter the employe id :");
            int id = int.Parse(Console.ReadLine());
            Employe e0 = new Employe();
            Employee e1 = new Employee (name , id);
            Console.WriteLine($"The Employe ID is :{e1.Eid}");
            Console.WriteLine($"The name of employe is :{e1.Ename}");
        }
    }
}
