using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class myclass2
    {
        public void mymethod2(string name)
        {
            Console.WriteLine("Hello, " + name + "! This is method with parameters without return type");
        }
    }
    internal class NameType2
    {
        static void Main(string[] args)
        {
            myclass2 obj = new myclass2();
            obj.mymethod2("Akash");
        }
    }
}
