using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    
        // Base Class
        class HeadOffice
        {
            // Fields (Changed to protected so derived classes can access them if needed, or kept private)
            private int headphone;
            private string headOfficeLocation;

            // Constructor
            public HeadOffice(int headphone, string headOfficeLocation)
            {
                this.headphone = headphone;
                this.headOfficeLocation = headOfficeLocation;
            }

            // Display Method
            public void HeadDisplay()
            {
                Console.WriteLine("Head Office ph num is: " + headphone);
                Console.WriteLine("Head Office Location is: " + headOfficeLocation);
            }
        }

        // Derived Class 1 (Inherits from HeadOffice)
        class Branch : HeadOffice
        {
            private int bid;
            private string bname;
            private string blocation;

            // Constructor passing hardcoded values to the base (HeadOffice) constructor
            public Branch(int bid, string bname, string blocation) : base(04024242, "Delhi")
            {
                this.bid = bid;
                this.bname = bname;
                this.blocation = blocation;
            }

            // Display Method
            public void BranchDisplay()
            {
                Console.WriteLine("Branch id is: " + bid);
                Console.WriteLine("Branch name is: " + bname);
                Console.WriteLine("Branch Location is: " + blocation);
                base.HeadDisplay(); // Calling base class method
            }
        }

        // Derived Class 2 (Inherits from Branch - Forming Multilevel Inheritance)
        class Employee : Branch
        {
            private int eid;
            private string ename;
            private int esal;

            // Constructor passing hardcoded values to the parent (Branch) constructor
            public Employee(int eid, string ename, int esal) : base(1, "Ameerpet", "Ameerpet")
            {
                this.eid = eid;
                this.ename = ename;
                this.esal = esal;
            }

            // Display Method
            public void EmployeeDisplay()
            {
                Console.WriteLine("Employee id is: " + eid);
                Console.WriteLine("Employee name: " + ename);
                Console.WriteLine("Employee Salary: " + esal);
                base.BranchDisplay(); // Calling parent class method
            }
        }

        // Main Execution Class
        class Program
        {
            static void Main(string[] args)
            {
                // Creating an object of the lowest derived class
                Employee emp = new Employee(101, "Akash", 50000);

                // Calling the display chain
                emp.EmployeeDisplay();

               
            }
        }
    

}
