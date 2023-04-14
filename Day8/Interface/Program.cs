using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ifigure ifigure = new circle();
            ifigure.Dimension = 14;
            Console.WriteLine(ifigure.Area());
            Console.WriteLine(ifigure.Premeter());
        }
    }
    interface Ifigure
    {
        int Dimension { get; set; }
        double Area();
        double Premeter();

    }
    class circle : Ifigure
    {
        int _radius;
        public int Dimension {
            get { return _radius; }
            set { _radius = value; }
                
                }
        public double Area() { return Math.PI * _radius * _radius; }
        public double Premeter() { return 2 * Math.PI*_radius; }
    }
    class square : Ifigure
    {
        int _rad;
        public int Dimension
        {
            get { return _rad; }
            set { _rad = value; }   
        }
        public double Area()
        {
            return _rad * _rad;
        }
        public double Premeter()
        {
            return Math.PI / _rad;
        }
    }


}
