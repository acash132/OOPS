using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Lclass
    {
        public int sum(int x,int y)
        {
            int result = x + y;
            return result;
        }
    }
    internal class Method4
    {
        static void Main(string[] args)
        {
            Lclass obj = new Lclass();
            int sumResult = obj.sum(5, 10);
            Console.WriteLine("Returned value from sum method: " + sumResult);
        }
    }
}
