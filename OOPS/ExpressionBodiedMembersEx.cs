using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class EBM
    {
        public void PrintMessage() => Console.WriteLine("Hello, World!");
        public int Add(int a, int b) => a + b;
    }
    internal class ExpressionBodiedMembersEx
    {
        static void Main()
        {
            EBM ebm = new EBM();
            ebm.PrintMessage();
            Console.WriteLine(ebm.Add(5, 10));
        }
    }
}
