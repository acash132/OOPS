//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    sealed class Student
//    {
//        public int SId { get; set; }
//        public string SName { get; set; }
//        public string College { get; set; }
//        public Student(int sId, string sName, string college)
//        {
//            SId = sId;
//            SName = sName;
//            College = college;
//        }
//        public void StudentDisplay()
//        {
//            Console.WriteLine("Student ID: " + SId);
//            Console.WriteLine("Student Name: " + SName);
//            Console.WriteLine("College: " + College);
//        }

//    }

//    class College : Student
//    {
//        int Cid;
//        string Cname;
//        string Caddress;
//        public College(int Cid, string Cname, string Caddress) : base(1, "ABC", "XYZ")
//        {
//            this.Cid = Cid;
//            this.Cname = Cname;
//            this.Caddress = Caddress;

//        }
//        public void CollegeDisplay()
//        {
//            Console.WriteLine("College ID: " + Cid);
//            Console.WriteLine("College Name: " + Cname);
//            Console.WriteLine("College Address: " + Caddress);
//            base.StudentDisplay();
//        }
//    }
//    internal class SealedClassEx1
//    {
//        static void Main(string[] args)
//        {
//            College college = new College(101, "ABC College", "apt 101");
//            //college.StudentDisplay();
//            college.CollegeDisplay();
//        }

//    }
//}
