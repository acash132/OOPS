//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    interface IShape
//    {
//        void Area(); 
//        double Perimeter();

//    }
//    public class Circle : IShape
//    {
//        public double Radius { get; set; }
//        public Circle(double radius)
//        {
//            Radius = radius;
//        }
//        public void Area()
//        {
//            Console.WriteLine($"Area of Circle: {Math.PI * Radius * Radius}");
//        }
//        public double Perimeter()
//        {
//            return 2 * Math.PI * Radius;
//        }
//    }
//    public class Rectangle : IShape
//    {
//        public double Length { get; set; }
//        public double Width { get; set; }

//        public Rectangle(double length, double width)
//        {
//            Length = length;
//            Width = width;
//        }
//        public double Perimeter()
//        {
//            return 2 * (Length + Width);
//        }
//        public void Area()
//        {
//            Console.WriteLine("Area of Rectangle: " + (Length * Width));
//        }
//        internal class InterfacesDefaultMethod
//        {
//            static void Main()
//            {
//                Circle circle = new Circle(5);
//                circle.Area();
//                Console.WriteLine("Perimeter of Circle: " + circle.Perimeter());
//                Rectangle rectangle = new Rectangle(4, 6);
//                rectangle.Area();
//                Console.WriteLine("Perimeter of Rectangle: " + rectangle.Perimeter());
//                IShape shape = new Circle(3);
//                shape.Area();
//                Console.WriteLine("Perimeter of Shape: " + shape.Perimeter());
//                shape = new Rectangle(2, 5);
//                shape.Area();
//            }
//        }
//    }
//}
