using System;
using System.Linq;
using System.Text;

namespace ConcatExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            string[] cars = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };
            string[] buses = { "Газель", "Икарус", "ЛиАЗ"};
 
            // объединяет с дубликатами
            var vehicles = cars.Concat(buses);
 
            foreach (string v in vehicles)
                Console.WriteLine(v);
        }
    }
}