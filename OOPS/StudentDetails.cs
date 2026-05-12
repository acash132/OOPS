using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Student
    {
        public int SId; 
        public string SName; 
        public int SAge; 
        public static string College;//Static member to store college name

        public void DisplayDetails()
        {
            Console.WriteLine("Student ID: " + SId);
            Console.WriteLine("Student Name: " + SName);
            Console.WriteLine("Student Age: " + SAge);
            Console.WriteLine("College: " + College);
        }
    }
    internal class StudentDetails
    {
        static void Main(string[] args)
        {
            Student.College = "Osmania University"; // Setting the static member
            Student[] students = new Student[5]; // Creating an array of Student objects
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student(); // Initializing each Student object
                Console.WriteLine("Enter details for student " + (i + 1) + ":");
                Console.Write("ID: ");
                students[i].SId = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                students[i].SName = Console.ReadLine();
                Console.Write("Age: ");
                students[i].SAge = int.Parse(Console.ReadLine());
            }

            // Displaying details of all students
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("\nDetails of student " + (i + 1) + ":");
                students[i].DisplayDetails();
            }
        }
    }
}
