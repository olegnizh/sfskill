using System;
using System.Linq;
using System.Text;

namespace DistinctExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            string[] cars = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };
 
            // удалим дубликаты
            var uniqueCars = cars.Distinct();
 
            foreach (string v in uniqueCars)
                Console.WriteLine(v);
        }
    }
}