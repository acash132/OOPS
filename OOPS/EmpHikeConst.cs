//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
   


//        class Employee1 
//        {
            
//            int Eid;
//            string Ename;
//            int ESalary;
//            decimal Hike;
//            static string Company = "InfoTech";

//            //Constructor: Initializes the object at the time of creation
//            public Employee1(int id, string name, int salary)
//            {
//                Eid = id;
//                Ename = name;
//                ESalary = salary;
                
//                Hike = ESalary * 0.1m;
//            }

//            public void DisplayDetails()
//            {
//                Console.WriteLine("\n--- Employee Record ---");
//                Console.WriteLine("Employee ID: " + Eid);
//                Console.WriteLine("Employee Name: " + Ename);
//                Console.WriteLine("Employee Salary: " + ESalary);
//                Console.WriteLine("Company: " + Company);
//                Console.WriteLine("Employee Hike: " + Hike);
//            }
//        }

//        internal class EmpHike1
//        {
//            static void Main(string[] args)
//            {
//                Employee1[] employees = new Employee1[2];
//                for (int i = 0; i < employees.Length; i++)
//                {
                   

//                    Console.Write("Enter ID: ");
//                    int id = int.Parse(Console.ReadLine());

//                    Console.Write("Enter Name: ");
//                    string name = Console.ReadLine();

//                    Console.Write("Enter Salary: ");
//                    int salary = int.Parse(Console.ReadLine());

                    
//                    employees[i] = new Employee1(id, name, salary);
//                }

//                Console.WriteLine("\nDisplaying All Employee Details:");
//                for (int i = 0; i < employees.Length; i++)
//                {
//                    employees[i].DisplayDetails();
//                }
//            }
//        }
//    }


