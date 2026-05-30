//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
   
//    public class BankAccount
//    {
//        // Private field to store the balance
//        private double balance;

//        // Constructor to initialize the balance
//        public BankAccount(double initialBalance)
//        {
//            if (initialBalance >= 0)
//            {
//                balance = initialBalance;
//            }
//            else
//            {
//                balance = 0;
//                Console.WriteLine("Initial balance can't be negative. Setting balance to 0.");
//            }
//        }

//        // Public method to get the current balance (read-only access)
//        public double GetBalance()
//        {
//            return balance;
//        }

//        // Public method to deposit money (with validation)
//        public void Deposit(double amount)
//        {
//            if (amount > 0)
//            {
//                balance += amount;
//                Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
//            }
//            else
//            {
//                Console.WriteLine("Deposit amount must be positive.");
//            }
//        }

//        // Public method to withdraw money (with validation)
//        public void Withdraw(double amount)
//        {
//            if (amount > 0 && amount <= balance)
//            {
//                balance -= amount;
//                Console.WriteLine($"Withdrawn: {amount}. New Balance: {balance}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid withdrawal amount.");
//            }
//        }
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            // Creating a new bank account with an initial balance
//            BankAccount account = new BankAccount(500);

//            // Checking initial balance
//            Console.WriteLine("Initial Balance: " + account.GetBalance());

//            // Trying to deposit money
//            account.Deposit(200);

//            // Trying to withdraw money
//            account.Withdraw(150);

//            // Trying to withdraw an invalid amount
//            account.Withdraw(600);

//            // Trying to deposit a negative amount
//            account.Deposit(-50);
//        }
//    }

//    internal class Task1BankAc
//    {
//    }
//}
