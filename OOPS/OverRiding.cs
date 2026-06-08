using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Base Class Display Method");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("Derived Class Display Method");
        }
    }
    internal class OverRiding
    {
        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            DerivedClass derivedObj = new DerivedClass();
            baseObj.Display(); // Calls Base Class Display Method
            derivedObj.Display(); // Calls Derived Class Display Method
            // Polymorphism: Base class reference pointing to derived class object
            BaseClass polyObj = new DerivedClass();
            polyObj.Display(); // Calls Derived Class Display Method due to overriding
        }
    }
}
