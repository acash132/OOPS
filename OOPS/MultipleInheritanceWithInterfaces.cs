//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    interface IphoneBasic
//    // Multiple Inheritance is not possible in C# using classes
//    {
//        void Calling();
//        void Receiving();
//        void SendingMessages();

//        void EndCall();
       
//    }
//    class IphoneSE : IphoneBasic
//    // Multiple Inheritance is not possible in C# using classes
//    {
//        public void Calling()
//        {
//            Console.WriteLine("IphoneSE Calling");
//        }
//        public void EndCall()
//        {
//            Console.WriteLine("IphoneSE End Call");
//        }
//        public void Receiving()
//        {
//            Console.WriteLine("IphoneSE Receiving");
//        }
//        public void SendingMessages()
//        {
//            Console.WriteLine("IphoneSE Sending Messages");
//        }
//    }

//    interface IphoneAdvance
        
//    {
//        void FaceID();
//        void VideoCalling();
//        void AirDrop();
//    }

//    class iphone16 : IphoneBasic, IphoneAdvance
//    //by implementing both interfaces, we can achieve multiple inheritance in C#    
    
//    {
//        public void AirDrop()

//        {
//            Console.WriteLine("Iphone16 AirDrop");
//        }
//        public void Calling()
//        {
//            Console.WriteLine("Iphone16 Calling");
//        }
//        public void EndCall()
//        {
//            Console.WriteLine("Iphone16 End Call");
//        }
//        public void FaceID()
//        {
//            Console.WriteLine("Iphone16 FaceID");
//        }
//        public void Receiving()
//        {
//            Console.WriteLine("Iphone16  Receiving");
//        }
//        public void SendingMessages()
//        {
//            Console.WriteLine("Iphone16 Sending Messages");
//        }
//        public void VideoCalling()
//        {
//            Console.WriteLine("Iphone16 Video Calling");
//        }
//    }
//    internal class MultipleInheritanceWithInterfaces
//    {
//        static void Main()
//        {
//            // Multiple Inheritance is not possible in C# using classes
//            // but it is possible using interfaces
//            IphoneBasic basic = new IphoneSE();
//            // basic.FaceID(); //
//            // Not possible as basic is of type IphoneBasic which does not
//            // have FaceID method
//            basic.Calling();
//            basic.Receiving();
//            basic.SendingMessages();
//            basic.EndCall();

//            basic = new iphone16();
//            // basic.FaceID(); // Not possible as basic is of type IphoneBasic which does not
//            // have FaceID method
//            basic.Calling();
//            basic.Receiving();
//            basic.SendingMessages();
//            basic.EndCall();

//            IphoneAdvance advance = new iphone16();
//            // advance.Calling(); // Not possible as advance is of type IphoneAdvance which does not
//            // have Calling method
//            advance.FaceID();
//            advance.VideoCalling();
//            advance.AirDrop();

//            iphone16 i16 = new iphone16();
//            // i16.FaceID(); // Possible as i16 is of type iphone16 which has FaceID method
//            i16.Calling();
//            i16.Receiving();
//            i16.SendingMessages();
//            i16.EndCall();
//            i16.FaceID();
//            i16.VideoCalling();
//            i16.AirDrop();
//        }
//    }
//}
