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
        static string Company="ABC";

        public void GetDetails()
        {
            Console.WriteLine("Enter Employee ID:");
            Eid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            Ename = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            ESalary = int.Parse(Console.ReadLine());
        }

        public static void DisplayCompany()
        {
            Console.WriteLine("Company: " + Company);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID: " + Eid);
            Console.WriteLine("Employee Name: " + Ename);
            Console.WriteLine("Employee Salary: " + ESalary);
            Console.WriteLine("Company: " + Company);
        }
    }
    internal class EmpDetails
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();
                employees[i].GetDetails();
            }
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].DisplayDetails();
            }
            Employee.DisplayCompany();
        }
    }
}
