//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
    

//    public class Counter
//    {
        
//        public int InstanceCount = 0;

        
//        public static int StaticCount = 0;

//        public Counter()
//        {
            
//            InstanceCount++;
//            StaticCount++;
//        }

//        public void DisplayCounts(string objectName)
//        {
//            Console.WriteLine($"{objectName} InstanceCount: {InstanceCount} and  StaticCount: {StaticCount}");
//        }
//    }


//    internal class Task2StaticVariableDemo
//    {
//        static void Main()
//        {
//            Console.WriteLine("--- Creating Objects ---");

//            Counter obj1 = new Counter();
//            obj1.DisplayCounts("Object 1");

//            Counter obj2 = new Counter();
//            obj2.DisplayCounts("Object 2");

//            Counter obj3 = new Counter();
//            obj3.DisplayCounts("Object 3");

//            Console.WriteLine("--- Modifying Static Variable Directly ---");

            
//            Counter.StaticCount = 100;

//            Console.WriteLine("Set Static count to 100");

//            obj1.DisplayCounts("Object 1");
//            obj2.DisplayCounts("Object 2");
//            obj3.DisplayCounts("Object 3");
//        }
//    }
//}
