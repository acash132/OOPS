using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
   
        
        public interface IPaymentGateway
        {
            void ProcessPayment(double amount);
        }

        // Implementing the Interface in different classes

        public class PayPalGateway : IPaymentGateway
        {
            public void ProcessPayment(double amount)
            {
                Console.WriteLine($"Processing PayPal payment of Rs{amount}...");
                
                Console.WriteLine("PayPal payment successful!\n");
            }
        }

        public class UPIGateway : IPaymentGateway
        {
            public void ProcessPayment(double amount)
            {
                Console.WriteLine($"Processing UPI payment of Rs{amount}...");
               
                Console.WriteLine("UPI payment successful!\n");
            }
        }

        public class CreditCardGateWay : IPaymentGateway
        {
            public void ProcessPayment(double amount)
            {
                Console.WriteLine($"Processing Credit Card payment of Rs{amount}...");
                
                Console.WriteLine("Credit Card payment successful!\n");
            }
        }

        public class NetBanking : IPaymentGateway
        {
            public void ProcessPayment(double amount)
            {
                Console.WriteLine($"Processing Net Banking payment of Rs{amount}...");
             
                Console.WriteLine("Net Banking payment successful!\n");
            }
        }

 
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("--- Payment Checkout System --- ");

                double cartTotal = 1500;

                // Using polymorphism: The reference type is the interface, 
                // but the object is the specific implementation.

                IPaymentGateway paymentMethod1 = new PayPalGateway();
                paymentMethod1.ProcessPayment(cartTotal);

                IPaymentGateway paymentMethod2 = new UPIGateway();
                paymentMethod2.ProcessPayment(cartTotal);

                IPaymentGateway paymentMethod3 = new CreditCardGateWay();
                paymentMethod3.ProcessPayment(cartTotal);

                IPaymentGateway paymentMethod4 = new NetBanking();
                paymentMethod4.ProcessPayment(cartTotal);

                Console.WriteLine("All transactions completed.");
            }
        }
    
}
