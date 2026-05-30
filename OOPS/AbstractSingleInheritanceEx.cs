//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    abstract class Vehicle
//    {
//        protected String VehicleName;
//        public Vehicle(string vname) 
//        {
//            this.VehicleName = vname;
//            Console.WriteLine("Vehicle is called");

//        }
//        public void ShowVehicleDetails()
//        {
//            Console.WriteLine($"Vehicle name is {VehicleName}");
//        }
//        public abstract void VehicleType();
//    }

//    abstract class VehicleModel : Vehicle
//    {
//        protected String ModelName;
//        public VehicleModel(string Vehiclename, string ModelName) : base(Vehiclename)
//        {
//            this.ModelName = ModelName;
//            Console.WriteLine("VehicleModel is calling");

//        }
//        public void DisplayName()
//        {
//            Console.WriteLine($"Model Name is {ModelName}");
//        }
//        public abstract void ModelType();
//    }
//    class VehicleData : VehicleModel
//    {
//        public int VehicleNum;
//        public VehicleData(string Vehiclename, string ModelName,int VehicleNum) : base(Vehiclename, ModelName)
//        {
//            this.VehicleNum = VehicleNum;
//            Console.WriteLine("Vehicle data is called");

//        }
//        public override void VehicleType()
//        {
//            Console.WriteLine("Cars");
//        }
//        public override void ModelType()
//        {
//            Console.WriteLine("Electric");
//        }
//    }
//    internal class AbstractSingleInheritanceEx
//    {
//        static void Main()
//        {
//            VehicleData vd = new VehicleData("Tesla", "Avi", 1111);
//            vd.ModelType();
//            vd.VehicleType();
//            vd.DisplayName();
//            vd.ShowVehicleDetails();
//        }
//    }
//}
