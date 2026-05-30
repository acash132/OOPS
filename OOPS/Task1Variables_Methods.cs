//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{


//    public class BankAccount
//    {

//        public static string BankName;


//        public string AccNo;
//        public decimal Balance;


//        public BankAccount(string accNo, decimal initialBalance)
//        {
//            AccNo = accNo;
//            Balance = initialBalance;
//        }


//        public void Deposit(decimal amount)
//        {
//            if (amount > 0)
//            {
//                Balance += amount;
//                Console.WriteLine($"Succesfully Deposited..New Balance is {Balance}");
//            }
//            else
//            {
//                Console.WriteLine(" Deposit amount must be greater than zero.");
//            }
//        }

//        // Method to withdraw money
//        public void Withdraw(decimal amount)
//        {
//            if (amount <= 0)
//            {
//                Console.WriteLine("Withdrawal amount must be greater than zero.");
//            }
//            else if (amount > Balance)
//            {
//                Console.WriteLine($"Insufficient Balance, Current balance is {Balance}");
//            }
//            else
//            {
//                Balance -= amount;
//                Console.WriteLine($"After Withdraw, New Balance is {Balance}");
//            }
//        }

        
//        public void DisplayAccountInfo()
//        {
//            Console.WriteLine($"Bank: {BankName} , AccNo: {AccNo} , Balance: {Balance}");
//        }
//    }

    
//    internal class Task1Variables_Methods
//    {
       
//            static void Main()
//            {
//                // 1. Initialize the static variable (Only needs to be done once)
//                BankAccount.BankName = "Axis Bank";

//                // 2. Create instance objects
//                BankAccount account1 = new BankAccount("101", 50000m);
//                BankAccount account2 = new BankAccount("102", 120000m);

//                // 3. Display initial states
//                Console.WriteLine("--- Initial Account Information ---");
//                account1.DisplayAccountInfo();
//                account2.DisplayAccountInfo();

//                Console.WriteLine("--- Transactions for Account 1 ---");
//                account1.Deposit(150m);
//                account1.Withdraw(50m);
//                account1.Withdraw(1000m); 

//                Console.WriteLine("--- Transactions for Account 2 ---");
//                account2.Withdraw(200m);

//                // 4. Display final states
//                Console.WriteLine("--- Final Account Information ---");
//                account1.DisplayAccountInfo();
//                account2.DisplayAccountInfo();
//            }
        
//    }
//}
