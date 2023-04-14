using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shapes shapes = new Shapes();
            //shapes.DrawShapes();
            //Shapes cir = new circle();
            //cir.DrawShapes();
            //Shapes tri = new rectangular();
            //tri.DrawShapes();

            string[] s = { "circle", "rectangular" };
            Console.WriteLine("Enter the shape:");
            string a = Console.ReadLine();
            if(a == s[0])
            {
                Shapes cir = new circle();
                cir.DrawShapes();
            }else if(a == s[1])
            {
                Shapes tri = new rectangular();
                tri.DrawShapes();
            }
            else
            {
                Shapes shapes = new Shapes();
                shapes.DrawShapes();

            }



        }
    }

    class Shapes
    {
        public virtual void DrawShapes()
        {
            Console.WriteLine("draw");
        }
    }
    class circle:Shapes
    {
        public override void DrawShapes() {
            Console.WriteLine("circle");
        }
    }
    class rectangular : Shapes
    {
        public override void DrawShapes() {
            Console.WriteLine("rectangular");
        }
    }
}
