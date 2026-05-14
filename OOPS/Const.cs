using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Myclass
    {
        int a;
        int b;
        public Myclass() {
            a = 10;
            b = 20;
            Console.WriteLine("Constructor called");


        }

        public void Greet()
        {
            Console.WriteLine("Hello from the Greet method!");
            Console.WriteLine("value of a: " + a);
            Console.WriteLine("value of b: " + b);
        }

        public int Greet2() {
            return a + b;




        }
        public int subtract()
        {
            return a - b;
        }
        public int multiply()
        {
            return a * b;
        }
        public int divide()
        {
            return a / b;
        }
    }
    internal class Const
    {
        static void Main(string[] args)
        {
            Myclass obj = new Myclass();
            obj.Greet();
            Console.WriteLine("Sum of a and b: " + obj.Greet2());
            Console.WriteLine("Subtraction of a and b: " + obj.subtract());
            Console.WriteLine("Multiplication of a and b: " + obj.multiply());
            Console.WriteLine("Division of a and b: " + obj.divide());
        }
    }
}
