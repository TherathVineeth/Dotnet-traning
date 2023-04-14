using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Circle();
            figure.Dimension = 10;
            Console.WriteLine(figure.Area());


        }
    }

    abstract class Figure
    {
        public int Dimension;
        public abstract double Area();
        public abstract double Premeter();
    }
    class Circle:Figure
    {
        public override double Area() {
            return Math.PI * Dimension * Dimension;
        }
        public override double Premeter()
        {
            return 2* Math.PI * Dimension;
        }

    }
    class Preme:Figure
    {
        public override double Area()
        {
            return Dimension*Dimension;
        }

        public override double Premeter()
        {
            return 4 * Dimension;
        }
    }
}
