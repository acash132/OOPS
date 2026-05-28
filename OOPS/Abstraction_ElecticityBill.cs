using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    
        abstract class ElectricityBoard
        {
            // Concrete method shared by all derived classes
            public void BillDetails()
            {
                Console.WriteLine("\n--- Electricity Bill Generated ---");
            }

            // Abstract method to be implemented by derived classes
            public abstract void CalculateBill(double units);
        }

        class ResidentialCust : ElectricityBoard
        {
            public override void CalculateBill(double units)
            {
                // Example rate: ₹5 per unit
                double bill = units * 5.0;
                Console.WriteLine("Residential Customer Bill: ₹" + bill);
            }
        }

        class CommercialCust : ElectricityBoard
        {
            public override void CalculateBill(double units)
            {
                // Example rate: ₹9 per unit
                double bill = units * 9.0;
                Console.WriteLine("Commercial Customer Bill: ₹" + bill);
            }
        }

        class IndustrialCust : ElectricityBoard
        {
            public override void CalculateBill(double units)
            {
                // Example rate: ₹12 per unit
                double bill = units * 12.0;
                Console.WriteLine("Industrial Customer Bill: ₹" + bill);
            }
        }

        class AgriculturalCust : ElectricityBoard
        {
            public override void CalculateBill(double units)
            {
                // Example rate: Free (₹0 per unit)
                double bill = units * 0;
                Console.WriteLine("Agricultural Customer Bill: ₹" + bill);
            }
        }

        internal class ElectricityBillExecution
        {
            static void Main(string[] args)
            {
                Console.Write("Enter Electricity Units Consumed: ");
                double units = Convert.ToDouble(Console.ReadLine());

                // Base class reference pointing to derived class objects (Polymorphism)
                ElectricityBoard board;

                // Residential
                board = new ResidentialCust();
                board.BillDetails(); // Called once to show the header
                board.CalculateBill(units);

                // Commercial
                board = new CommercialCust();
                board.CalculateBill(units);

                // Industrial
                board = new IndustrialCust();
                board.CalculateBill(units);

                // Agricultural
                board = new AgriculturalCust();
                board.CalculateBill(units);

            }
        }
    }
    