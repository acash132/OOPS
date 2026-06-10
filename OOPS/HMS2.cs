//using System;

//namespace OOPS
//{
//    internal class HMS2
//    {
        
//        public interface IBillable
//        {
//            string GetBillingName();
//            string GetBillingType();
//            double CalculateAdditionalCharges();
//        }

//        public interface IAppointment
//        {
//            void Schedule();
//            void Cancel();
//        }

        
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

       
//        public class Patient : HospitalMember, IBillable
//        {
//            private string contactNumber;
//            private string patientType; // "Inpatient" or "Outpatient"

//            public Patient(string id, string name, string contactNumber, string patientType)
//                : base(id, name)
//            {
//                SetContactNumber(contactNumber);
//                this.patientType = patientType;
//            }

//            public void SetContactNumber(string newContact)
//            {
//                this.contactNumber = !string.IsNullOrWhiteSpace(newContact) ? newContact : "Unknown";
//            }

//            public string GetContactNumber() => this.contactNumber;
//            public string GetPatientType() => this.patientType;

//            public override void DisplayDetails()
//            {
//                Console.WriteLine($"Patient ID: {GetID()} | Name: {GetName()} | Type: {patientType}");
//            }

//            public string GetBillingName() => GetName();
//            public string GetBillingType() => this.patientType;

//            public double CalculateAdditionalCharges()
//            {
                
//                if (patientType.Equals("Inpatient"))
//                {
//                    return 150.00; // Room charges
//                }
//                else if (patientType.Equals("Outpatient"))
//                {
//                    return 40.00; // Consultation fee
//                }
//                return 0;
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

//            public string GetSpecialization() => specialization;

//            public override void DisplayDetails()
//            {
//                Console.WriteLine($"Doctor ID: {GetID()} | Dr. {GetName()} | Specialization: {specialization}");
//            }
//        }

        
//        public class Appointment : IAppointment
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

//            public void Schedule()
//            {
//                this.isCancelled = false;
//                Console.WriteLine($"Appointment {appointmentID} scheduled for Patient '{patient.GetName()}' with Dr. '{doctor.GetName()}' on {appointmentDate.ToShortDateString()}.");
//            }

//            public void Cancel()
//            {
//                this.isCancelled = true;
//                Console.WriteLine($"Appointment {appointmentID} has been successfully cancelled.");
//            }
//        }

        
//        public class Billing
//        {
//            private string billID;
//            private IBillable billableTarget;
//            private double baseCost;

//            public Billing(string billID, IBillable target, double baseCost)
//            {
//                this.billID = billID;
//                this.billableTarget = target;
//                this.baseCost = baseCost;
//            }

//            public void GenerateBill()
//            {
//                double additionalCharges = billableTarget.CalculateAdditionalCharges();
//                double totalAmount = baseCost + additionalCharges;
//                string type = billableTarget.GetBillingType();

//                Console.WriteLine($"--- {type} Bill Breakdown ({billID}) ---");
//                Console.WriteLine($"Name: {billableTarget.GetBillingName()}");
//                Console.WriteLine($"Treatment Cost: Rs {baseCost}");

//                if (type.Equals("Inpatient"))
//                    Console.WriteLine($"Room & Accommodation Charges: Rs {additionalCharges}");
//                else
//                    Console.WriteLine($"Consultation Fee: Rs {additionalCharges}");

//                Console.WriteLine($"Total Amount Due: Rs {totalAmount}");
//                Console.WriteLine("Status: Payment Processed.\n");
//            }
//        }

       
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("=== HOSPITAL MANAGEMENT SYSTEM ===\n");

//                // Registering patients
//                Patient patient1 = new Patient("P101", "raju", "94432888", "Inpatient");
//                Patient patient2 = new Patient("P102", "ravi", "879022233", "Outpatient");

//                Console.WriteLine("Registered Patients:");
//                patient1.DisplayDetails();
//                patient2.DisplayDetails();
//                Console.WriteLine();

//                // Adding Doctors
//                Doctor doctor1 = new Doctor("D201", "Akash", "Cardiology");
//                Doctor doctor2 = new Doctor("D202", "Ram", "Pediatrics");

//                // Schedule & Cancel Appointments using Interface references
//                IAppointment appt1 = new Appointment("A9001", patient1, doctor1, DateTime.Now.AddDays(1));
//                appt1.Schedule();

//                IAppointment appt2 = new Appointment("A9002", patient2, doctor2, DateTime.Now.AddDays(3));
//                appt2.Schedule();
//                appt2.Cancel();
//                Console.WriteLine();

//                // Generate Bills using Interface implementation
//                Billing bill1 = new Billing("B001", patient1, 500.00);
//                bill1.GenerateBill();

//                Billing bill2 = new Billing("B002", patient2, 120.00);
//                bill2.GenerateBill();
//            }
//        }
//    }
//}