using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    interface Ishape {
        void Area();
        double Perimeter();
    }

    public class Circle : Ishape
    {
        public double Radius { get; set; }
        public void Area()
        {
            Console.WriteLine("Area of Circle: " + (Math.PI * Radius * Radius));
        }
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
    class Rectangle : Ishape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public void Area()
        {
            Console.WriteLine("Area of Rectangle: " + (Length * Width));
        }
        public double Perimeter()
        {
            return 2 * (Length + Width);
        }
    }
    internal class InterfaceEx
    {
        static void Main()
        {
            Circle circle = new Circle { Radius = 5 };
            circle.Area();
            Console.WriteLine("Perimeter of Circle: " + circle.Perimeter());
            Rectangle rectangle = new Rectangle { Length = 4, Width = 6 };
            rectangle.Area();
            Console.WriteLine("Perimeter of Rectangle: " + rectangle.Perimeter());
        }
    }
}
