using System;

namespace MultiLevelInheritanceHCS
{
    
    class HeadOffice
    {
        private int officePhone;
        private string officeLocation;

       
        public HeadOffice(int officePhone, string officeLocation)
        {
            this.officePhone = officePhone;
            this.officeLocation = officeLocation;
        }


        public void HeadOfficeDisplay()
        {
            Console.WriteLine("Head Office Phone Number: " + officePhone);
            Console.WriteLine("Head Office Location: " + officeLocation);
        }
    }

   
    class CollegeName : HeadOffice
    {
        private string collegeCode;
        private string collegeName;

        
        public CollegeName(string collegeCode, string collegeName) : base(1800123456, "New Delhi")
        {
            this.collegeCode = collegeCode;
            this.collegeName = collegeName;
        }

        
        public void CollegeDisplay()
        {
            Console.WriteLine("College Code: " + collegeCode);
            Console.WriteLine("College Name: " + collegeName);
            base.HeadOfficeDisplay();
        }
    }

    
    class Student : CollegeName
    {
        private int studentRoll;
        private string studentName;

        
        public Student(int studentRoll, string studentName) : base("C1", "IITH")
        {
            this.studentRoll = studentRoll;
            this.studentName = studentName;
        }

        
        public void StudentDisplay()
        {
            Console.WriteLine("Student Roll No: " + studentRoll);
            Console.WriteLine("Student Name: " + studentName);
            base.CollegeDisplay(); 
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            Student std = new Student(1, "Akash");
 	    std.StudentDisplay();

            
            
            
           

          
        }
    }
}