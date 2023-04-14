using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ElectronicPhone ep = new ElectronicPhone("Normal");
            Console.WriteLine(ep.ToString());
            ep.Run();
        }
    }

    class Telephone
    {
        protected string _phonetype;
        public string Phonetype
        {
            get { return _phonetype; }
            set { _phonetype = value; }
        }
        public Telephone() { }

        public Telephone(string phonetype)
        {
            _phonetype = phonetype;
        }
        public void Ring()
        {
            Console.WriteLine($"Ringing the {_phonetype}.");
        }
    }

    class ElectronicPhone : Telephone
    {
        string s = "Digital";

       public   ElectronicPhone() { }
        public override string ToString()
        {
            return $"The first name is {_phonetype}";
        }


        public ElectronicPhone(string phonetype): base(phonetype) {
          
            _phonetype=s;


        }

       
        public void Run()
        {
             base.Ring();
        }

    }
}
