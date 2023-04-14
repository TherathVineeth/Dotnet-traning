using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fruitsample
{
     class Program
    {
        static void Main(string[] args)
        {
            Orange orange = new Orange(0,"orange","T");
            Orange orange1 =   new Orange(2,"apple","A");
            orange.Display();
            orange1.Display();
            
           

        }
    }

    class Fruits
    {
       protected int _num;

        public int Num {
            get { return _num; }
             set { 
                if(value > 0) {
                    _num = value;
                        }

                else {
                    Console.WriteLine("Invalide");
                }
            }
        }
       protected string _name;
        public string Name {
            get { return _name;} 
             set { _name = value; }
        }
        public Fruits()
        {

        }

        public Fruits(int num, string name)
        {
            Num = num;
            Name = name;
        }


    }

    class  Orange : Fruits
    {
        private string _orgin;
        private string[] _places = { "H","M","T"};
        public string Orgin
        {
            get { return _orgin;}
            set { if (_places.Contains(value)) { _orgin = value; } else { Console.WriteLine("Invalide"); } }
        }
        public Orange() { }
        public Orange(int num, string name,string orgin):base(num,name)
        {
            _orgin = orgin;
        }

        public void Display()
        {
            
            Console.WriteLine($"The {_num}st Fruit Name {_name} is orgined from {_orgin}");
        }
       
    }
    
}
