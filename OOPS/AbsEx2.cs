//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class myclass
//    {
//        public void display() {
//            Console.WriteLine("Welcome to OOPS")
//                ;
//        }
//        public virtual void show()
//           {
//            Console.WriteLine("Show is calling");
//        }
//    }
//    class dc : myclass
//    {
//        public void message()
//        {
//            Console.WriteLine("Message is Calling");
//        }
//        public override void show()
//        {
//            Console.WriteLine("This is overridden Method");
//        }
//    }
//    internal class AbsEx2
//    {
//        static void main()
//        {
//            myclass obj= new myclass();
//            obj.display();
//            obj.show();

//            dc objdc= new dc();
//            objdc.message();
//            objdc.show();
//        }
//    }
//}
