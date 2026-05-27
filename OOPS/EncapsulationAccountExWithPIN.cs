//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class AccountExWithPIN
//    {
//        private double balance;
//        private string pin;
//        public AccountExWithPIN(string initialPin)
//        {
//            pin = initialPin;
//            balance = 0;
//        }
//        public void Deposit(double amount, string enteredPin)
//        {
//            if (enteredPin == pin)
//            {
//                if (amount > 0)
//                {
//                    balance += amount;
//                    Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
//                }
//                else
//                {
//                    Console.WriteLine("Deposit amount must be positive.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Invalid PIN. Deposit failed.");
//            }
//        }
//        public void Withdraw(double amount, string enteredPin)
//        {
//            if (enteredPin == pin)
//            {
//                if (amount > 0 && amount <= balance)
//                {
//                    balance -= amount;
//                    Console.WriteLine($"Withdrew: {amount}, New Balance: {balance}");
//                }
//                else
//                {
//                    Console.WriteLine("Invalid withdrawal amount.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Invalid PIN. Withdrawal failed.");
//            }
//        }
//        public double GetBalance(string enteredPin)
//        {
//            if (enteredPin == pin)
//            {
//                return balance;
//            }
//            else
//            {
//                Console.WriteLine("Invalid PIN. Cannot retrieve balance.");
//                return -1; // Indicating an error
//            }
//        }
//    }
//    internal class EncapsulationAccountExWithPIN
//    {
//        static void Main(string[] args)
//        {
//            AccountExWithPIN myAccount = new AccountExWithPIN("1234");
//            myAccount.Deposit(1000, "1234");
//            myAccount.Withdraw(200, "1234");
//            myAccount.Withdraw(10, "123");
//            Console.WriteLine($"Current Balance: {myAccount.GetBalance("1234")}");
//        }
//    }
//}
