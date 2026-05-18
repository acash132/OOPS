using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Student
    {
        protected Student(int Sid)
        {
            Console.WriteLine("Protected constructor - Student ID: " + Sid);
        }
    }

    class CollegeStudent : Student
    {
        public CollegeStudent(int Sid) : base(Sid)
        {
            Console.WriteLine("CollegeStudent constructor - Student ID: " + Sid);
        }
    }
    internal class ProtectedAmBase
    {
        static void Main(string[] args)
        {
            CollegeStudent cs = new CollegeStudent(123);
        }
    }
}
