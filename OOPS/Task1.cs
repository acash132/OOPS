//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
    

//    public class Employee
//    {
//        // Instance fields (unique to each object)
//        public int eid;
//        public string ename;
//        public double esal;

//        // Static field (shared across all objects of the class)
//        public static string empcompany;

//        // Constructor to initialize the instance fields
//        public Employee(int eid, string ename, double esal)
//        {
//            this.eid = eid;
//            this.ename = ename;
//            this.esal = esal;
//        }

//        // Method to display individual employee details
//        public void EmpDisplay()
//        {
//            Console.WriteLine("--- Employee Details ---");
//            Console.WriteLine("ID: " + eid);
//            Console.WriteLine("Name: " + ename);
//            Console.WriteLine("Salary: Rs" + esal);
//        }

//        // Method to display the company name 
//        // (Note: Made static since it deals with a static field)
//        public static void CompanyDisplay()
//        {
//            Console.WriteLine("Company: " + empcompany);
//        }

//        // Method to apply a 10% salary increment
//        public void SalaryHike()
//        {
//            // Calculate 10% of current salary and add it
//            esal = esal + (esal * 0.10);
//            Console.WriteLine(ename + " received a 10% hike! New Salary: Rs" + esal);
//        }

//        // Main method to test the class functionality
//        public static void Main(string[] args)
//        {
//            // 1. Set the static company name (applies to all employees)
//            Employee.empcompany = "TechSoft";

//            // 2. Create an Employee object
//            Employee emp1 = new Employee(101, "akash", 60000);

//            // 3. Call the display methods
//            // Notice how static methods are called on the Class, and instance methods on the object
//            Employee.CompanyDisplay();
//            emp1.EmpDisplay();

//            Console.WriteLine(); // Blank line for readability

//            // 4. Apply the salary hike and display updated details
//            emp1.SalaryHike();
//            emp1.EmpDisplay();
//        }
//    }
//}
