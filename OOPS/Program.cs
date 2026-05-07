using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{

    class Counter
    {
        private int InstanceCount = 0;
        private static int StaticCount = 0;

        public void Increment()
        {
            InstanceCount++;
            StaticCount++;
            Console.WriteLine("Instance Count: " + InstanceCount);
            Console.WriteLine("Static Count: " + StaticCount);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter();
            Counter counter2 = new Counter();

            Console.WriteLine("Counter 1:");
            counter1.Increment();
            
            counter1.Increment();

            Console.WriteLine("Counter 2:");
            counter2.Increment();
            counter2.Increment();
        }
    }
}
