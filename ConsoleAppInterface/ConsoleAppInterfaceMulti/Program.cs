using System;

namespace ConsoleAppInterfaceMulti
{
    interface IPolygon
    {
        // method without body
        void calculateArea(int a, int b);
    }

    interface IColor
    {
        void getColor();
    }

    // implements two interface
    class Rectangle : IPolygon, IColor
    {
        // implementation of IPolygon interface
        public void calculateArea(int a, int b)
        {
            int area = a * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }

        // implementation of IColor interface
        public void getColor()
        {
            Console.WriteLine("Red Rectangle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Multi");

            Rectangle r1 = new Rectangle();
            r1.calculateArea(100, 200);
            r1.getColor();

        }
    }
}
