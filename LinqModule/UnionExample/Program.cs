using System;
using System.Linq;
using System.Text;

namespace UnionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            string[] cars = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };
            string[] buses = { "Газель", "Икарус", "ЛиАЗ"};
 
            // Соединим две коллекции без повторяющихся элементов
            var vehicles = cars.Union(buses);
 
            foreach (string v in vehicles)
                Console.WriteLine(v);
        }
    }
}