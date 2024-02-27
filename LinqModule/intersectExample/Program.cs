using System;
using System.Linq;
using System.Text;

namespace intersectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            string[] cars = { "Волга", "Москвич", "Нива", "Газель" };
            string[] buses = { "Газель", "Икарус", "ЛиАЗ"};
 
            // поищем машины, которые можно считать микроавтобусами
            var microBuses = cars.Intersect(buses);
 
            foreach (string mb in microBuses)
                Console.WriteLine(mb);
        }
    }
}