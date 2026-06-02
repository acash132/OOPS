//using System;


//namespace OOPS
//{
//    class Student
//    {
//        int Sid;
//        string Sname;
//        string College;

//        public Student(int Sid, string Sname, string College)
//        {
//            this.Sid = Sid;
//            this.Sname = Sname;
//            this.College = College;
//        }
//        public void StudentDisplay()
//        {
//            Console.WriteLine("Student Id: " + Sid);
//            Console.WriteLine("Student Name: " + Sname);
//            Console.WriteLine("College Name: " + College);
//        }
//    }
//    class College : Student
//    {
//        int Cid;
//        string CAddress;
//        string CNumber;
//        public College(int Cid, string CAddress, string CNumber) : base(1, "Akash", "ABC")
//        {
//            this.Cid = Cid;
//            this.CAddress = CAddress;
//            this.CNumber = CNumber;

//        }
//        public void CollegeDisplay()
//        {
//           Console.WriteLine("College Id: " + Cid);
//            Console.WriteLine("College Address: " + CAddress);
//            Console.WriteLine("College Number: " + CNumber);
//        }
//    }
//    internal class SingleInheritance
//    {
//        static void Main(string[] args)
//        {
//            College c = new College(101, "Pune", "020-12345678");
//            c.StudentDisplay();
//            c.CollegeDisplay();
//        }
//    }
//}