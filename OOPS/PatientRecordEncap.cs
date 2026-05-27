//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
    

//    public class Patient
//    {
//        // 1. Private variables (Data Hiding)
//        private string name;
//        private int age;
//        private string medicalHistory;

//        // 2. Constructor to pass name and age details when creating the object
//        public Patient(string patientName, int patientAge)
//        {
//            name = patientName;
//            age = patientAge;
//            medicalHistory = "No history provided."; // Default value
//        }

//        // 3. Public properties to safely access and modify private data
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }

//        public int Age
//        {
//            get { return age; }
//            set
//            {
//                // Encapsulation allows us to add validation logic
//                if (value > 0 && value <= 120)
//                {
//                    age = value;
//                }
//                else
//                {
//                    Console.WriteLine("Error: Please enter a valid age.");
//                }
//            }
//        }

//        public string MedicalHistory
//        {
//            get { return medicalHistory; }
//            set { medicalHistory = value; }
//        }

//        // 4. Method to display the patient's record
//        public void DisplayRecord()
//        {
//            Console.WriteLine("=== Patient Record ===");
//            Console.WriteLine($"Name:            {name}");
//            Console.WriteLine($"Age:             {age}");
//            Console.WriteLine($"Medical History: {medicalHistory}");
//            Console.WriteLine("======================\n");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Passing the name and age details through the constructor
//            Patient patient1 = new Patient("mukesh", 36);

//            // Displaying the initial record
//            patient1.DisplayRecord();

//            // Updating the medical history using the public property
//            patient1.MedicalHistory = "Recovering from oral cancer. Prescribed rest for 20 weeks.";

//            // Attempting to set an invalid age to demonstrate encapsulation validation
//            patient1.Age = -5; // This will trigger the error message in the Age property

//            // Displaying the updated record
//            patient1.DisplayRecord();
//        }
//    }
//}
