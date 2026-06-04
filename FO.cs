using System;

namespace FunctionOverloading
{
    class Student
    {
        public void TotalMarks(int sub1, int sub2)
        {
            int Total = sub1 + sub2;
            Console.WriteLine($"Total Marks is {Total}");
        }

        public void TotalMarks(int sub1, int sub2, int sub3)
        {
            int Total = sub1 + sub2 + sub3;
            Console.WriteLine($"Total Marks is {Total}");
        }

        public void TotalMarks(int sub1, int sub2, int sub3, int sub4)
        {
            int Total = sub1 + sub2 + sub3 + sub4;
            Console.WriteLine($"Total Marks is {Total}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();

            // Corrected: Use the object instance 'obj' to call the methods
            obj.TotalMarks(88, 33);
            obj.TotalMarks(45, 66, 77);
            obj.TotalMarks(55, 66, 77, 88);
        }
    }
}