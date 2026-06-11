//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class NewClass
//    {
//        internal void Shows(int a, int b)
//        {
//            Console.WriteLine("value of a"+a);
//            Console.WriteLine("value of b" + b);
//        }
//        internal void Show<T1, T2>(T1 a, T2 b)
//        {
//            Console.WriteLine("First value: " + a);
//            Console.WriteLine("Second value: " + b);
//        }
//        internal static void Show1<T1, T2>(T1 a, T2 b)
//        {
//            Console.WriteLine("First value: " + a);
//            Console.WriteLine("Second value: " + b);
//        }
//    }
//    internal class MultiTypeGenerics
//    {
//        static void Main(string[] args)
//        {
//            NewClass newClass = new NewClass();

//            newClass.Shows(10, 20);
//            newClass.Show < string, int > ("Hello", 20);
//            NewClass.Show1<string, int>("World", 30);
//            NewClass.Show1<int, string>(40, "Generics");
//        }
//    }
//}
