//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    internal class HMS1
//    {





//        // Abstract Base Class
//        public abstract class HospitalMember
//        {
//            private string id;
//            private string name;

//            public HospitalMember(string id, string name)
//            {
//                this.id = id;
//                this.name = name;
//            }


//            public string GetID() { return id; }
//            public string GetName() { return name; }

//            public abstract void DisplayDetails();
//        }

//        //Inheritance
//        public class Patient : HospitalMember
//        {
//            // Encapsulation
//            private string contactNumber;
//            private string patientType; //IP or OP

//            public Patient(string id, string name, string contactNumber, string patientType)
//                : base(id, name)
//            {
//                SetContactNumber(contactNumber);
//                this.patientType = patientType;
//            }


//            public void SetContactNumber(string newContact)
//            {
//                if (!string.IsNullOrWhiteSpace(newContact))
//                {
//                    this.contactNumber = newContact;
//                }
//                else
//                {
//                    this.contactNumber = "Unknown";
//                }
//            }


//            public string GetContactNumber()
//            {
//                return this.contactNumber;
//            }

//            public string GetPatientType()
//            {
//                return this.patientType;
//            }

//            public override void DisplayDetails()
//            {
//                Console.WriteLine($"Patient ID: {GetID()} | Name: {GetName()} | Type: {patientType}");
//            }
//        }


//        public class Doctor : HospitalMember
//        {
//            private string specialization;

//            public Doctor(string id, string name, string specialization)
//                : base(id, name)
//            {
//                this.specialization = specialization;
//            }

//            public string GetSpecialization()
//            {
//                return specialization;
//            }

//            public override void DisplayDetails()
//            {
//                Console.WriteLine($"Doctor ID: {GetID()} | Dr. {GetName()} | Specialization: {specialization}");
//            }
//        }




//        public class Appointment
//        {
//            private string appointmentID;
//            private Patient patient;
//            private Doctor doctor;
//            private DateTime appointmentDate;
//            private bool isCancelled;

//            public Appointment(string appointmentID, Patient patient, Doctor doctor, DateTime date)
//            {
//                this.appointmentID = appointmentID;
//                this.patient = patient;
//                this.doctor = doctor;
//                this.appointmentDate = date;
//                this.isCancelled = false;
//            }


//            public void ScheduleAppointment()
//            {
//                this.isCancelled = false;
//                Console.WriteLine($"Appointment {appointmentID} scheduled for Patient '{patient.GetName()}' with Dr. '{doctor.GetName()}' on {appointmentDate.ToShortDateString()}.");
//            }

//            public void CancelAppointment()
//            {
//                this.isCancelled = true;
//                Console.WriteLine($"Appointment {appointmentID} has been successfully cancelled.");
//            }
//        }



//        //PolyMorphism
//        public class Billing
//        {
//            private string billID;
//            private Patient patient;
//            private double baseCost;

//            public Billing(string billID, Patient patient, double baseCost)
//            {
//                this.billID = billID;
//                this.patient = patient;
//                this.baseCost = baseCost;
//            }


//            public void GenerateBill()
//            {
//                double totalAmount = baseCost;

//                if (patient.GetPatientType().Equals("Inpatient"))
//                {
//                    double roomCharges = 150.00;
//                    totalAmount += roomCharges;
//                    Console.WriteLine($"--- Inpatient Bill Breakdown ({billID}) ---");
//                    Console.WriteLine($"Patient: {patient.GetName()}");
//                    Console.WriteLine($"Treatment Cost: Rs{baseCost}");
//                    Console.WriteLine($"Room & Accommodation Charges: Rs{roomCharges}");
//                    Console.WriteLine($"Total Amount Due: Rs{totalAmount}");
//                }
//                else if (patient.GetPatientType().Equals("Outpatient"))
//                {
//                    double consultationFee = 40.00;
//                    totalAmount += consultationFee;
//                    Console.WriteLine($"--- Outpatient Bill Breakdown ({billID}) ---");
//                    Console.WriteLine($"Patient: {patient.GetName()}");
//                    Console.WriteLine($"Treatment Cost: Rs{baseCost}");
//                    Console.WriteLine($"Consultation Fee: Rs{consultationFee}");
//                    Console.WriteLine($"Total Amount Due: Rs{totalAmount}");
//                }

//                Console.WriteLine("Status: Payment Processed.\n");
//            }
//        }



//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("=== HOSPITAL MANAGEMENT SYSTEM ===\n");

//                //Registering patients
//                Patient patient1 = new Patient("P101", "raju", "94432888", "Inpatient");
//                Patient patient2 = new Patient("P102", "ravi", "879022233", "Outpatient");

//                Console.WriteLine("Registered Patients:");
//                Console.WriteLine($"- {patient1.GetName()} (ID: {patient1.GetID()}) (Contact: {patient1.GetContactNumber()})");
//                Console.WriteLine($"- {patient2.GetName()} (ID: {patient2.GetID()}) (Contact: {patient2.GetContactNumber()})");

//                // Adding Doctors
//                Doctor doctor1 = new Doctor("D201", "Akash", "Cardiology");
//                Doctor doctor2 = new Doctor("D202", "Ram", "Pediatrics");

//                // Schedule & Cancel Appointments
//                Appointment appt1 = new Appointment("A9001", patient1, doctor1, DateTime.Now.AddDays(1));
//                appt1.ScheduleAppointment();

//                Appointment appt2 = new Appointment("A9002", patient2, doctor2, DateTime.Now.AddDays(3));
//                appt2.ScheduleAppointment();
//                appt2.CancelAppointment();


//                //Generate Bills
//                Billing bill1 = new Billing("B001", patient1, 500.00);
//                bill1.GenerateBill();

//                Billing bill2 = new Billing("B002", patient2, 120.00);
//                bill2.GenerateBill();


//            }
//        }


//    }
//}

