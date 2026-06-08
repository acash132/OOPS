using System;

namespace HierarchicalInheritance
{

class Vehicle
{
public void Drive()
{
Console.WriteLine("Vehicle is driving");
}
}


class Bike : Vehicle
{
public void BDrive()
{
Console.WriteLine("Bike is driving");
}
}


class Car : Vehicle
{
public void CDrive()
{
Console.WriteLine("Car is driving");
}
}

class Program
{
static void Main(string[] args)
{

Bike b = new Bike();
b.Drive(); 
b.BDrive(); 




Car c = new Car();
c.Drive(); 
c.CDrive(); 
}
}
}