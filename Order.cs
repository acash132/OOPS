using System;

namespace OrderOfParameters
{
class OrderParam
{

public void Details(int age,String name)
{
Console.WriteLine($"age is {age} and name is {name}");
}


public void Details(String name,int age)
{
Console.WriteLine($"name is {name} and age is {age} ");
}

}

class Program
{
static void Main(string[] args)
{

OrderParam obj = new OrderParam();

obj.Details(20,"Akash");


obj.Details("Akash",100);
}
}
}