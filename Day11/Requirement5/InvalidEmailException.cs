using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    internal class InvalidEmailException:Exception
    {
        string email;
        public InvalidEmailException()
        {

        }
        public InvalidEmailException(string email)
        {
            this.email = email;
        }
        public void inform()
        {
            Console.WriteLine("InvalideEmailException:Invalide Email for the user");
        }
    }
}
