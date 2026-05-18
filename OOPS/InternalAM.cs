using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class MyClass
    {
        internal int a;
        public MyClass()
        {
            a = 10;
        }
        public void Display()
        {
            Console.WriteLine("Value of a: " + a);
        }

    }
    class NewClass
    {
        public void Show()
        {
            MyClass obj = new MyClass();
            Console.WriteLine("Accessing internal member a: " + obj.a);
        }
    }
    internal class InternalAM
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Display();
        }
    }
}
