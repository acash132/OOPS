using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Employee
    {
            int Eid;
            string Ename;
            int ESalary;
            decimal Hike;
            static string Company = "InfoTech";
    
            public void GetDetails()
            {
                Console.WriteLine("Enter Employee ID:");
                Eid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                Ename = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                ESalary = int.Parse(Console.ReadLine());
                Hike = ESalary * 0.1m; // Assuming a 10% hike
                

        }
    
          
    
            public void DisplayDetails()
            {
                Console.WriteLine("Employee ID: " + Eid);
                Console.WriteLine("Employee Name: " + Ename);
                Console.WriteLine("Employee Salary: " + ESalary);
                Console.WriteLine("Company: " + Company);
                Console.WriteLine("Employee Hike: " + Hike);
        }

    }
    internal class EmpHike
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[2];
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();
                employees[i].GetDetails();
            }
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].DisplayDetails();
            }
            
        }
    }
}
