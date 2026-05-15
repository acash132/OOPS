using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class car
    {
         
         string model;
         int year;
         string color;
        public car()
        {
            model = "Honda Civic";
            year = 2025;
            color = "Black";
        }
        public car(string Model, int Year, string Color)
        {
            model = Model;
            year = Year;
            color = Color;
        }
        public void DisplayDetails()
        {
            if (year >= 1886)
            {
                Console.WriteLine("Car Model: " + model);
                Console.WriteLine("Car Year: " + year);
                Console.WriteLine("Car Color: " + color);
            }
            else
            {
                Console.WriteLine("Invention before 1886");
            }
        }

    }
    internal class CarParamConst
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car car2 = new car("Mahindra Scorpio", 2026, "White");
            car1.DisplayDetails();
            Console.WriteLine();
            car2.DisplayDetails();
            car car3 = new car("Ford ", 1800, "Red");
            car3.DisplayDetails();
        }
    }
}
