//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    abstract class HMWSSB
//    {
//        public void BillDetails() {
//            Console.WriteLine("Bill Generated for Water Consumed");
//        }
//        public abstract void GetBills(double units);

//    }
//    class ResidentialCust : HMWSSB
//    {
//        public override void GetBills(double units)
//        {
//            double bill = units * 7;
//            Console.WriteLine("Res Cust Bill "+bill);
//        }
//    }
//    class CommercialCust : HMWSSB
//    {
//        public override void GetBills(double units)
//        {
//            double bill = units * 10;
//            Console.WriteLine("Commercial Cust Bill " + bill);

//        }
//    }

//    class IndustryCust : HMWSSB
//    {
//        public override void GetBills(double units)
//        {
//            double bill = units * 15;
//            Console.WriteLine("Industrial Cust Bill " + bill);

//        }
//    }



//    class AgriCust : HMWSSB
//    {
//        public override void GetBills(double units)
//        {
//            double bill = units * 0;
//            Console.WriteLine("Agri Cust Bill " + bill);

//        }
//    }

//    internal class AbsRTE
//    {
//        static void Main(string[] args)
//        {
//            HMWSSB obj=new ResidentialCust();
//            obj.BillDetails();
//            Console.WriteLine("Enter Units Consumed");
//            double units=Convert.ToDouble(Console.ReadLine());
//            obj.GetBills(units);
//            obj=new CommercialCust();
//            obj.GetBills(units);
//            obj=new IndustryCust();
//            obj.GetBills(units);
//            obj=new AgriCust();
//            obj.GetBills(units);

                
//        }
//    }
//}
