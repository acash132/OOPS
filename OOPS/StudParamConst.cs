//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
    

//namespace OOPS
//    {
//        class Student
//        {
//            // Fields
//            private int sid;
//            private string sname;
//            private int sage;

//            // Parameterized Constructor with Age Validation
//            public Student(int id, string name, int age)
//            {
//                sid = id;
//                sname = name;

//                // Business Rule: Age must be between 18 and 60
//                if (age >= 18 && age <= 60)
//                {
//                    sage = age;
//                }
//                else
//                {
//                    Console.WriteLine("Setting default age to 18.");
//                    sage = 18; 
//                }
//            }

//            // Method to display student data
//            public void DisplayStudentDetails()
//            {
//                Console.WriteLine("\n--- Student Details ---");
//                Console.WriteLine("Student ID   : " + sid);
//                Console.WriteLine("Student Name : " + sname);
//                Console.WriteLine("Student Age  : " + sage);
//                Console.WriteLine("-----------------------");
//            }
//        }

//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                //Test Case 1
//                Console.WriteLine("Creating Student 1 (Valid Age)");
//                Student student1 = new Student(101, "Akash", 24);
//                student1.DisplayStudentDetails();

//                // Test Case 2
//                Console.WriteLine("\nCreating Student 2 (Invalid Age)");
//                Student student2 = new Student(102, "Modi", 75);
//                student2.DisplayStudentDetails();
//            }
//        }
//    }
//}

