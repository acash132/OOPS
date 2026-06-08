using System;

namespace HierarchicalInheritanceExample
{
    
    class HeadOffice
    {
        public void DisplayRules()
        {
            Console.WriteLine("Head Office: Administration");
        }
    }


    class College : HeadOffice
    {
        public void ShowCollegeDetails()
        {
            Console.WriteLine("College: Managing Infra");
        }
    }

    
    class Student : HeadOffice
    {
        public void ShowStudentDetails()
        {
            Console.WriteLine("Student Attending Classes");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            College myCollege = new College();
            myCollege.DisplayRules();      
            myCollege.ShowCollegeDetails(); 

           
            Student myStudent = new Student();
            myStudent.DisplayRules();       
            myStudent.ShowStudentDetails(); 
        }
    }
}