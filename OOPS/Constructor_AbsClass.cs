using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract class Person {
        protected string name; 
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Person Constructor Called");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name:{name},Age:{age}");
        }
        public abstract void Role();
    }

    class Student:Person 
    {
        public int RollNo;
        public Student(string name, int age, int rollno) : base(name, age)
        {
            this.RollNo = rollno;
            Console.WriteLine("Student constructor called");

        }

        public void StudentRoll()
        {
            Console.WriteLine("Student Roll no" + RollNo);
        }

        public override void Role()
        {
            Console.WriteLine("Iam a Student");
        }
    }
    internal class Constructor_AbsClass
    {
        static void Main()
        {
            Student s = new Student("Akash", 22, 100);
            s.StudentRoll();
            s.DisplayInfo();
            s.Role();
        }
    }
}
