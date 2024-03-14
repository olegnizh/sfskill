using System;

namespace ConsoleAppInterfacePract
{
    interface IPolygon
    {
        // method without body
        void calculateArea();
    }
    // implements interface
    class Rectangle : IPolygon
    {
        // implementation of IPolygon interface
        public void calculateArea()
        {
            int l = 30;
            int b = 90;
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
    class Square : IPolygon
    {
        // implementation of IPolygon interface
        public void calculateArea()
        {
            int l = 30;
            int area = l * l;
            Console.WriteLine("Area of Square: " + area);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface practical");

            Rectangle r1 = new Rectangle();
            r1.calculateArea();

            Square s1 = new Square();
            s1.calculateArea();

        }
    }
}
