using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Myclass
    {
        protected  int a = 10;
        protected  void display()
        {
            Console.WriteLine("Value of a: " + a);
        }
    }

    class DerivedClass : Myclass
    {
        public void Show()
        {
            display(); // Accessing the protected method from the base class
            Console.WriteLine("Accessing protected member a: " + a); // Accessing the protected field from the base class
        }
    }
    internal class ProtectedAM
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            // obj.display(); // This will cause a compile-time error because display() is protected and cannot be accessed from outside the class hierarchy
            obj.Show();
        }
    }
}
