using System;
using System.Linq;
using System.Text;

namespace SkipTakeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            var cars = new [] { "Volvo", "Opel",  "Suzuki",  "Toyota" , "Lada", "Kamaz" };
 
            // пропустим первые два элемента
            var skip2 = cars.Skip(2);
 
            foreach (var car in skip2)
                Console.WriteLine(car);

            Console.WriteLine();
            
            // пропустим первые два элемента, и выведем следующие два
            var skip3 = cars.Skip(2).Take(2);
 
            foreach (var car in skip3)
                Console.WriteLine(car);
        }
    }
}