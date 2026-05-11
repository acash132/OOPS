using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Class2   
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }
        public void Greet(int x)
        {
            Console.WriteLine("Hello, " + x + "! Welcome to Methods");
        }

    }
    internal class MethodType2
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.Add(5, 10);
            class2.Greet(25);
        }
    }
}
