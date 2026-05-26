using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Student
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        // Copy constructor
        public Student(Student other)
        {
            Sid = other.Sid;
            Name = other.Name;
        }
        public Student(int sid, string name)
        {
            Sid = sid;
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine("Student ID: " + Sid);
            Console.WriteLine("Student Name: " + Name);
        }
    }
    internal class CopyConstructorEx
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(101, "Alice");
            Console.WriteLine("Original Student:");
            student1.Display();
            // Creating a new student using the copy constructor
            Student student2 = new Student(student1);
            Console.WriteLine("\nCopied Student:");
            student2.Display();
        }
    }
}
