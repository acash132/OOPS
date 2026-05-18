//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class Student
//    {
//        int Sid;
//        string Sname;
//        string Sdept;
//        public Student()
//        {
//            Sid = 1;
//            Sname = "Not Provided";
//            Sdept = "Not Provided";
//        }
//        public Student(int sid, string sname, string sdept)
//        {
//            Sid = sid;
//            Sname = sname;
//            Sdept = sdept;
//        }
//        public Student(int sid, string sname)
//        {
//            Sid = sid;
//            Sname = sname;
//            Sdept = "Not Provided";
//        }

//        public Student(string sname)
//        {
//            Sid = 0;
//            Sname = sname;
//            Sdept = "Not Provided";
//        }

//        public Student(string sname, string sdept)
//        {
//            Sid = 0;
//            Sname = sname;
//            Sdept = sdept;
//        }
//        public Student(int sid)
//        {
//            Sid = sid;
//            Sname = "Not Provided";
//            Sdept = "Not Provided";
//        }
//        public void Display()
//        {
//            Console.WriteLine("Student ID: " + Sid);
//            Console.WriteLine("Student Name: " + Sname);
//            Console.WriteLine("Student Department: " + Sdept);
//        }
        
        
//    }

//    internal class ConstOverload
//    {
//        static void Main(string[] args)
//        {
//            Student student1 = new Student();
//            Console.WriteLine("Student 1 Details:");
//            student1.Display();
//            Console.WriteLine("\n-----------------------------\n");
//            Student student2 = new Student(101, "Akash");
//            Console.WriteLine("Student 2 Details:");
//            student2.Display();
//            Console.WriteLine("\n-----------------------------\n");
//            Student student3 = new Student("Suresh");
//            Console.WriteLine("Student 3 Details:");
//            student3.Display();
//            Console.WriteLine("\n-----------------------------\n");
//            Student student4 = new Student(104);
//            Console.WriteLine("Student 4 Details:");
//            student4.Display();
//            Console.WriteLine("\n-----------------------------\n");
//            Student student5 = new Student(105, "sai", "CSE");
//            Console.WriteLine("Student 5 Details:");
//            student5.Display();
//            Console.ReadLine();

//        }
//    }
//}
