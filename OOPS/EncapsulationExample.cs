//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class Account
//    {
//        private double balance;
//        public void Deposit(double amount)
//        {
//            if (amount > 0)
//            {
//                balance += amount;
//                Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
//            }
//            else
//            {
//                Console.WriteLine("Deposit amount must be positive.");
//            }
//        }
//        public void Withdraw(double amount)
//        {
//            if (amount > 0 && amount <= balance)
//            {
//                balance -= amount;
//                Console.WriteLine($"Withdrew: {amount}, New Balance: {balance}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid withdrawal amount.");
//            }
//        }
//        public double GetBalance()
//        {
//            return balance;
//        }
//    }
//    internal class EncapsulationExample
//    {
//        static void Main(string[] args)
//        {
//            Account myAccount = new Account();
//            myAccount.Deposit(1000);
//            myAccount.Withdraw(200);
//            Console.WriteLine($"Current Balance: {myAccount.GetBalance()}");
//        }
//    }
//}
