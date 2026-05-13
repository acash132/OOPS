//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    internal class StudentPercentage
//    {
       
//        class Student
//        {
//            public int SId;
//            public string SName;
//            public int SAge;
//            public double[] Marks = new double[3]; // Array to store 3 subject marks
//            public static string College; // Static member

//            public void DisplayDetails()
//            {
//                // Calculating Total
//                double total = 0;
//                foreach (double m in Marks)
//                {
//                    total += m;
//                }

//                // Calculating Percentage
//                double percentage = (total / (Marks.Length * 100)) * 100;

//                Console.WriteLine("Student ID: " + SId);
//                Console.WriteLine("Student Name: " + SName);
//                Console.WriteLine("Student Age: " + SAge);
//                Console.WriteLine("College: " + College);
//                Console.WriteLine("Total Marks: " + total);
//                Console.WriteLine("Percentage: " + percentage.ToString() + "%");
//            }
//        }

//        internal class StudentDetails
//        {
//            static void Main(string[] args)
//            {
//                Student.College = "Osmania University";

//                Student[] students = new Student[3];

//                for (int i = 0; i < students.Length; i++)
//                {
//                    students[i] = new Student();
//                    Console.WriteLine("\n--- Enter details for student " + (i + 1) + " ---");

//                    Console.Write("ID: ");
//                    students[i].SId = int.Parse(Console.ReadLine());

//                    Console.Write("Name: ");
//                    students[i].SName = Console.ReadLine();

//                    Console.Write("Age: ");
//                    students[i].SAge = int.Parse(Console.ReadLine());

//                    // Inputting marks
//                    for (int j = 0; j < students[i].Marks.Length; j++)
//                    {
//                        Console.Write("Enter Mark for Subject " + (j + 1) + ": ");
//                        students[i].Marks[j] = double.Parse(Console.ReadLine());
//                    }
//                }

//                // Displaying details of all students
//                Console.WriteLine("\n==============================");
//                Console.WriteLine("       STUDENT REPORTS        ");
//                Console.WriteLine("==============================");

//                for (int i = 0; i < students.Length; i++)
//                {
//                    Console.WriteLine("\nDetails of student " + (i + 1) + ":");
//                    students[i].DisplayDetails();
//                    Console.WriteLine("------------------------------");
//                }

                
//            }
//        }
//    }
//}

