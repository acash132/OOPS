//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class myClass
//    {
//        public int x;
//        public int y;
//        // Parameterized Constructor
//        public myClass(int a, int b)
//        {
//            x = a;
//            y = b;
//        }

//        public myClass() // Default Constructor
//        {
//            x = 1;
//            y = 2;
//            Console.WriteLine("Default constructor called");
//        }
//        public void Greet()
//        {
//            Console.WriteLine("Value of x: " + x);
//            Console.WriteLine("Value of y: " + y);
//            Console.WriteLine("Hello from the Greet method!");
//        }

//        public int Greet2()
//        {
//            return x + y;

//        }
//    }
//    internal class ConstructorEX
//    {
//        static void Main(string[] args)
//        {
//            myClass obj = new myClass(10, 20);
//            obj.Greet();
//            Console.WriteLine("Sum of x and y: " + obj.Greet2());
//        }
//    }
//}
