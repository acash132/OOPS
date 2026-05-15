using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Student
    {
         int SID ;
         string SName ;
         int SFee ;

        public Student()
        {
            SID = 1;
            SName = "Akash";
            SFee = 50000;
        }

        public Student(int Id, string Name, int Fee)
        {
            SID = Id;
            SName = Name;
            SFee = Fee;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student ID: " + SID);
            Console.WriteLine("Student Name: " + SName);
            Console.WriteLine("Student Fee: " + SFee);
        }


    }
    internal class StuDetails
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            Student stu2 = new Student(2, "Sai", 60000);
            stu1.DisplayDetails();
            stu2.DisplayDetails();
        }
    }
}
