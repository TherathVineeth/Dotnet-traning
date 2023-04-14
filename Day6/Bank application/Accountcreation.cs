using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application
{
    internal class Accountcreation
    {
        public int Aid;
        public string Aname;
        private double Bbalebce;
        private double Adepositamount;
        private double adepositamount
        {
            get { return Adepositamount; }
        }

        public Accountcreation(int id, string name, double depositamount)
        {
            this.Aid = id;
            this.Aname = name;
            this.Adepositamount = depositamount;
        }

       
       
        internal void Balence(int x)
        {
            if (x == Aid)
            {
                Console.WriteLine($"The balence of {Aname} account is = {Adepositamount}");
            }
            else
            {
                Console.WriteLine("ID  number is incorrect");
            }

        }

        internal void Display(int x)
        {
            if (x == Aid)
            {
                Console.WriteLine($"The Name is : {Aname}");
                Console.WriteLine($"The account balence : {Adepositamount}");
            }
            else
            {
                Console.WriteLine("ID  number is incorrect");
            }

        }
        internal void AddBalence(int x , double y)
        {
            if (x == Aid)
            {
                Adepositamount +=  y;
                Console.WriteLine($"The total amount is {Adepositamount}");
            }
            else
            {
                Console.WriteLine("ID number is incorrect");
            }
           
        }

       
    }
}
