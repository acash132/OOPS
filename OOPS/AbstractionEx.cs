using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract class AbstractClass
    {
        public void start() {
            Console.WriteLine("Class Started");

        }
        public void Resume()
        {
            Console.WriteLine("Class Resumed");
        }
        public void Display()
        {
            Console.WriteLine("Welcome");
        }
        public abstract void end();

    }
    class DerivedClass : AbstractClass
    {
        public override void end()
        {
            Console.WriteLine("Session Ended");
        }
    }
    internal class AbstractionEx
    {
        static void Main(string[] args)
        {
            AbstractClass obj= new DerivedClass();
            obj.Display();
            obj.start();
            obj.Resume();
            obj.end();
        }
    }
}
