using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GroupByExample.Models;

namespace GroupByExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            var cars = new List<Car>()
            {
                new Car("Suzuki", "JP"),
                new Car("Toyota", "JP"),
                new Car("Opel", "DE"),
                new Car("Kamaz", "RUS"),
                new Car("Lada", "RUS"),
                new Car("Honda", "JP"),
            };
            
            // Группировка по стране - производителю
            var carsByCountry = from car in cars
                group car by car.CountryCode;
 
            // Пробежимся по группам
            foreach (var grouping in carsByCountry)
            {
                Console.WriteLine(grouping.Key + ":");
  
                // внутри каждой группы пробежимся по элементам
                foreach (var car in grouping)
                    Console.WriteLine(car.Manufacturer);
  
                Console.WriteLine();
            }
            
            
            // Группировка по стране - производителю ( через метод - расширение)
            var carsByCountryViaExt = cars.GroupBy(car => car.CountryCode);
        }
    }
}