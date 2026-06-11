//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    internal class SealedClsEx2
//    {
       
//        sealed class PaymentGateway
//        {
//            public string ProviderName { get; set; }
//            public string MerchantId { get; set; }

//            public PaymentGateway(string providerName, string merchantId)
//            {
//                ProviderName = providerName;
//                MerchantId = merchantId;
//            }

//            public void ProcessTransaction(double amount)
//            {
//                Console.WriteLine("Connecting to " + ProviderName + "...");
//                Console.WriteLine("Verifying Merchant ID: " + MerchantId);
//                Console.WriteLine("Successfully processed transaction of Rs" + amount);

//            }
//        }

//        // 
//        // class CustomPayment : PaymentGateway
//        // {
//        //     public CustomPayment(string name, string id) : base(name, id)
//        //     {
//        //     }
//        // }

//        internal class SealedClassExample
//        {
//            static void Main(string[] args)
//            {
//                // 3. We cannot inherit from PaymentGateway, but we CAN create 
//                // an object (instance) of it and use its methods normally.

//                PaymentGateway gateway1 = new PaymentGateway("PayPal", "MERCH-998877");
//                gateway1.ProcessTransaction(150.75);

//                PaymentGateway gateway2 = new PaymentGateway("Stripe", "MERCH-112233");
//                gateway2.ProcessTransaction(45.00);


//            }
//        }
//    }
//}

