using System;

namespace TypeOfParameters
{
class NewClass
{
// Method 1: Accepts an integer parameter
public void TypeMethod(int a)
{
Console.WriteLine("val of a is " + a);
}

// Method 2: Overloaded method that accepts a string parameter
public void TypeMethod(string name)
{
Console.WriteLine("Name is " + name);
}
}

class Program
{
static void Main(string[] args)
{
// Creating an object of NewClass
NewClass obj = new NewClass();

// Calling the integer version of the method
obj.TypeMethod(10);

// Calling the string version of the method
obj.TypeMethod("Akash");
}
}
}