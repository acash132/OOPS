//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{


//    public class UserProfile
//    {
//        public string Username;
//        public string Email;
//        public int Age;

        
//        public UserProfile()
//        {
//            Username = "Guest";
//            Email = "NA";
//            Age = 0;
//        }

        
//        public UserProfile(string username)
//        {
//            Username = username;
//            Email = "NA";
//            Age = 0;
//        }

        
//        public UserProfile(string username, string email)
//        {
//            Username = username;
//            Email = email;
//            Age = 0;
//        }

        
//        public UserProfile(string username, string email, int age)
//        {
//            Username = username;
//            Email = email;
//            Age = age;
//        }

       
//        public void DisplayProfile()
//        {
//            Console.WriteLine($"Username: {Username} , Email: {Email} , Age: {Age}");
//        }
//    }


//    internal class Task3_ConstructorOverloading
//    {

//        static void Main()
//        {
//            Console.WriteLine("Creating Class Objects using Overloaded Constructors ");

            
//            UserProfile user1 = new UserProfile();

           
//            UserProfile user2 = new UserProfile("Akash");

            
//            UserProfile user3 = new UserProfile("Sai", "sai@gmail.com");

            
//            UserProfile user4 = new UserProfile("Suresh", "suresh@gmail.com", 28);

            
//            user1.DisplayProfile();
//            user2.DisplayProfile();
//            user3.DisplayProfile();
//            user4.DisplayProfile();
//        }

//    }
//}
