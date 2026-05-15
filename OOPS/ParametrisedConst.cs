//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class Employ
//    {
//         int EID ;
//         string EName;
//         double ESalary;

//        public Employ() {
//            EID = 1;
//            EName = "Akash";
//            ESalary = 50000.0;

//        }

//        public Employ(int Id, string Name, double Salary) {

//            EID = Id;
//            EName = Name;
//            ESalary = Salary;
//        }

//        public void DisplayDetails()
//        {
//            Console.WriteLine("Employee ID: " + EID);
//            Console.WriteLine("Employee Name: " + EName);
//            Console.WriteLine("Employee Salary: " + ESalary);
//        }
//    }
//    internal class ParametrisedConst
//    {
//        static void Main(string[] args)
//        {
//            Employ emp1 = new Employ();
//            Employ emp2 = new Employ(2, "Sai", 60000.0);

//            emp1.DisplayDetails();
//            emp2.DisplayDetails();
//        }
//    }
//}
