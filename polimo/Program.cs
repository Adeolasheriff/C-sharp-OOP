using System;

abstract class Vehicle
{
    public abstract void StartEngine();
}

class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }
}

class Program
{
    static void Main()
    {
        Vehicle myCar = new Car();
        myCar.StartEngine();
    }
}

