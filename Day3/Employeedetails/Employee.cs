using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employeedetails
{
    internal class Employee
    {
        public int Eid;
        public string Ename;
        Employee() { }
        public Employee(string name, int id)
        {
            Ename = name;
            Eid = id;
        }
    }
}
