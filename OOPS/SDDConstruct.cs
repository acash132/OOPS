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
        string sname;
        int sfee;
       
        public void StudentDisplay()
        {
            Console.WriteLine("Student ID: " + sid);
            Console.WriteLine("Student Name: " + sname);
            Console.WriteLine("Student Fee: " + sfee);
        }
    }
    internal class SDDConstruct
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.StudentDisplay();
            Student student2 = new Student();
            student2.StudentDisplay();
        }
    }
}
