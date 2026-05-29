//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
   

//    // ==========================================
//    // 1. ABSTRACTION (Interfaces)
//    // ==========================================
//    // In C#, it is a strict naming convention to start Interfaces with an 'I'.
//    // We define a contract: anything "IDrivable" must have these methods.
//    public interface IDrivable
//    {
//        void StartEngine();
//        void StopEngine();
//    }

//    // ==========================================
//    // 2. ABSTRACTION (Abstract Classes) & ENCAPSULATION
//    // ==========================================
//    // We can't create a raw "Vehicle" object. It must be a specific type of vehicle.
//    public abstract class Vehicle : IDrivable
//    {
//        // ENCAPSULATION: Using C# Properties.
//        // The 'get' is public so anyone can read it, but the 'set' is private, 
//        // meaning the data can only be changed from inside this class.
//        public string Brand { get; private set; }
//        public string Model { get; private set; }

//        // Protected means it can be modified directly by child classes
//        protected int Speed { get; set; }

//        // Constructor
//        public Vehicle(string brand, string model)
//        {
//            Brand = brand;
//            Model = model;
//            Speed = 0;
//        }

//        // Abstract method: Every child class MUST provide their own version.
//        public abstract void DisplayInfo();

//        // ==========================================
//        // 3. POLYMORPHISM (Compile-Time / Overloading)
//        // ==========================================
//        // Two methods with the exact same name, but different parameters.
//        public void Accelerate()
//        {
//            Speed += 10;
//            Console.WriteLine($"Accelerating. Speed: {Speed} km/h");
//        }

//        public void Accelerate(int increment)
//        {
//            Speed += increment;
//            Console.WriteLine($"Accelerating by {increment}. Speed: {Speed} km/h");
//        }

//        // Abstract interface methods that children must implement
//        public abstract void StartEngine();
//        public abstract void StopEngine();
//    }

//    // ==========================================
//    // 4. INHERITANCE
//    // ==========================================
//    // Car inherits from Vehicle using the ':' syntax
//    public class Car : Vehicle
//    {
//        private int numberOfDoors;

//        // The 'base' keyword calls the parent (Vehicle) constructor
//        public Car(string brand, string model, int numberOfDoors)
//            : base(brand, model)
//        {
//            this.numberOfDoors = numberOfDoors;
//        }

//        // ==========================================
//        // 5. POLYMORPHISM (Run-Time / Overriding)
//        // ==========================================
//        // Providing a specific implementation for the parent's abstract methods
//        public override void StartEngine()
//        {
//            Console.WriteLine("Car engine started: Vroom!");
//        }

//        public override void StopEngine()
//        {
//            Console.WriteLine("Car engine stopped.");
//        }

//        public override void DisplayInfo()
//        {
//            // Using C# String Interpolation ($"") for cleaner formatting
//            Console.WriteLine($"Car: {Brand} {Model} with {numberOfDoors} doors.");
//        }
//    }

//    // Another subclass to demonstrate inheritance
//    public class ElectricBike : Vehicle
//    {
//        private int batteryCapacity;

//        public ElectricBike(string brand, string model, int batteryCapacity)
//            : base(brand, model)
//        {
//            this.batteryCapacity = batteryCapacity;
//        }

//        public override void StartEngine()
//        {
//            Console.WriteLine("E-Bike turned on silently.");
//        }

//        public override void StopEngine()
//        {
//            Console.WriteLine("E-Bike turned off.");
//        }

//        public override void DisplayInfo()
//        {
//            Console.WriteLine($"E-Bike: {Brand} {Model} (Battery: {batteryCapacity}kWh)");
//        }
//    }

//    // ==========================================
//    // 6. CLASSES AND OBJECTS (The Entry Point)
//    // ==========================================
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Creating Objects (Instances of the Classes)
//            Car myCar = new Car("Toyota", "Camry", 4);
//            ElectricBike myBike = new ElectricBike("Zero", "SR/F", 14);

//            Console.WriteLine("--- Testing Car ---");
//            myCar.StartEngine();
//            myCar.DisplayInfo();

//            // Demonstrating Overloading (Compile-time polymorphism)
//            myCar.Accelerate();      // Uses the default accelerate (+10)
//            myCar.Accelerate(30);    // Uses the customized accelerate (+30)

//            Console.WriteLine("\n--- Testing E-Bike ---");
//            myBike.StartEngine();
//            myBike.DisplayInfo();
//            myBike.Accelerate(20);

//            Console.WriteLine("\n--- Polymorphism in Action ---");
//            // A parent class reference holding a child class object.
//            // It knows at run-time to call the Car's specific version of DisplayInfo().
//            Vehicle polyVehicle = new Car("Ford", "Mustang", 2);
//            polyVehicle.DisplayInfo();
//        }
//    }
//}
