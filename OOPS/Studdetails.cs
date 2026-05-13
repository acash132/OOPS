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
//        int Sage;
//        static string College;

//        public void GetDetails()
//        {
//            Console.WriteLine("Enter Student ID:");
//            Sid = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Student Name:");
//            Sname = Console.ReadLine();
//            Console.WriteLine("Enter Student Age:");
//            Sage = int.Parse(Console.ReadLine());
//        }

//        public static void DisplayCollege()
//        {
//            Console.WriteLine("College: " + College);
//        }

//        public  void DisplayDetails()
//        {
//            Console.WriteLine("Student ID: " + Sid);
//            Console.WriteLine("Student Name: " + Sname);
//            Console.WriteLine("Student Age: " + Sage);
//            Console.WriteLine("College: " + College);
//        }
//    }
//    internal class Studdetails
//    {
//        static void Main(string[] args)
//        {
//            Student[] students = new Student[2];
//            for (int i = 0; i < students.Length; i++)
//            {
//                students[i] = new Student();
//                students[i].GetDetails();
//            }
//            for (int i = 0; i < students.Length; i++)
//            {
//                students[i].DisplayDetails();
//            }
//                Student.DisplayCollege();

//        }

//    }
//}
