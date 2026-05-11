using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Lclass2
    {
        public string Name(string name)
        {
            return name;
        }
    }
    internal class NameType4
    {
        static void Main(string[] args)
        {
            Lclass2 obj = new Lclass2();
            string nameResult = obj.Name("Akash");
            Console.WriteLine("Returned value from name method: " + nameResult);
        }
    }
}
