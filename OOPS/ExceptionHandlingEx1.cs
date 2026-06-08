//using System;

//namespace OOPS
//{
//    // Created a Calculator class to implement Object-Oriented principles
//    class Calculator
//    {
//        // Method to perform division and handle potential exception
//        public void DivideNumbers()
//        {
//            try
//            {
//                Console.WriteLine("Enter a number:");
//                int a = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Enter a Number:");
//                int b = Convert.ToInt32(Console.ReadLine());

//                int div = a / b;
//                Console.WriteLine("Div Result is {0}", div);
//            }
//            catch (DivideByZeroException)
//            {
//                Console.WriteLine("Denominator can't be zero");
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Please enter a valid numeric integer.");
//            }
//            catch (OverflowException)
//            {
//                Console.WriteLine("The number entered is too large or too small for an Int32.");
//            }
//            catch(ArgumentNullException)
//            {
//                Console.WriteLine("Input cannot be null. Please enter a valid number.");
//            }
//            catch (ArgumentException)
//            {
//                Console.WriteLine("Invalid argument provided. Please check your input.");
//            }
//            catch (SystemException ex)
//            {
//                // Catching any other system-level exceptions that might occur
//                Console.WriteLine($"A system error occurred: {ex.Message}");
//            }
//            catch (ApplicationException ex)
//            {
//                // Catching any application-level exceptions that might occur
//                Console.WriteLine($"An application error occurred: {ex.Message}");
//            }
//            /* catch (InvalidOperationException ex)
//             {
//                 // Catching any invalid operations that might occur
//                 Console.WriteLine($"Invalid operation: {ex.Message}");
//             }*/
//           /* catch (NullReferenceException ex)
//            {
//                // Catching null reference exceptions that might occur
//                Console.WriteLine($"Null reference error: {ex.Message}");
//            }*/

//            catch (Exception ex)
//            {
//                // Catch-all for any other unexpected errors (like numbers too large for Int32)
//                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
//            }
//        }
//    }

//    internal class ExceptionHandlingEx1 // Fixed the typo "Eception" to "Exception"
//    {
//        static void Main(string[] args)
//        {
//            // Creating an object of the Calculator class
//            Calculator calc = new Calculator();

//            // Calling the method using the object
//            calc.DivideNumbers();

           
//        }
//    }
//}