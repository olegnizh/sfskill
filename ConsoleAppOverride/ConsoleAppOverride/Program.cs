using System;

namespace ConsoleAppOverride
{

    public static class Program
    {
        public static void Main()
        {
            Vehicle transport = new Truck();
            transport.Move();
        }
    }

    public class Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("Moving");
        }
    }

    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Car moving");
        }
    }

    public class Truck : Car
    {
        public void Move()
        {
            Console.WriteLine("Truck moving");
        }
    }

}
