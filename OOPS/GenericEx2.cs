using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class GenericEx2
    {
        
        // A generic class with two type parameters
        class KeyValuePair<TKey, TValue>
        {
            // Using properties instead of fields for better encapsulation
            public TKey Key { get; set; }
            public TValue Value { get; set; }

            internal KeyValuePair(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }

            internal void ShowDetails()
            {
                // typeof().Name is used to print the data type being used
                Console.WriteLine($"Key: {Key} [{typeof(TKey).Name}] | Value: {Value} [{typeof(TValue).Name}]");
            }
        }

        internal class GenericClassesEx2
        {
            static void Main(string[] args)
            {
                // Example 1: Integer Key, String Value
                KeyValuePair<int, string> student = new KeyValuePair<int, string>(101, "Alice");
                student.ShowDetails();

                // Example 2: String Key, Double Value
                KeyValuePair<string, double> product = new KeyValuePair<string, double>("Laptop", 1299.99);
                product.ShowDetails();

                // Example 3: String Key, Boolean Value
                KeyValuePair<string, bool> featureToggle = new KeyValuePair<string, bool>("DarkMode", true);
                featureToggle.ShowDetails();
            }
        }
    }
}

