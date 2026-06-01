//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{


//    public abstract class Shape
//    {
//        public string Name;

//        public Shape(string name)
//        {
//            Name = name;
//        }

//        public abstract double CalculateArea();

//        public void DisplayShapeInfo()
//        {
//            Console.WriteLine($"Shape: {Name}");
//        }
//    }

//    public class Circle : Shape
//    {
//        public double Radius;

//        public Circle(string name, double radius) : base(name)
//        {
//            Radius = radius;
//        }

//        public override double CalculateArea()
//        {

//            return Math.PI * Radius * Radius;
//        }
//    }

//    public class Rectangle : Shape
//    {
//        public double Length;
//        public double Breadth;

//        public Rectangle(string name, double length, double breadth) : base(name)
//        {
//            Length = length;
//            Breadth = breadth;
//        }

//        public override double CalculateArea()
//        {

//            return Length * Breadth;
//        }
//    }


//    internal class Task4_AbstractClass_Methods
//    {

//        static void Main()
//        {
//            Console.WriteLine("Abstract Class Demo");

//            Shape myCircle = new Circle("Circle", 5);
//            Shape myRectangle = new Rectangle("Rectangle", 4, 6);

//            myCircle.DisplayShapeInfo();
//            Console.WriteLine($"Area: {myCircle.CalculateArea()}");

//            myRectangle.DisplayShapeInfo();
//            Console.WriteLine($"Area: {myRectangle.CalculateArea()}");


//        }
//    }
//}

