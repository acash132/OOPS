using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Student
    {
        int sid;
        String sname;
        static String schoolName;
        // Static constructor
        static Student()
        {
            schoolName = "ABC School";
        }

        public Student(int sid, String sname)
        {
            this.sid = sid;
            this.sname = sname;
        }
        public void StudentDisplay()
        {
            Console.WriteLine("Student ID: " + sid);
            Console.WriteLine("Student Name: " + sname);
           
        }
        public static void DisplaySchoolName()
        {
            Console.WriteLine("School Name: " + schoolName);
        }
    }
    internal class StaticConstructorEx
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(101, "Alice");
            Student student2 = new Student(102, "Bob");
            student1.StudentDisplay();
            student2.StudentDisplay();
            Student.DisplaySchoolName();
        }
    }
}
