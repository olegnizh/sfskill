using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkipWhileTakeWhile.Models;

namespace SkipWhileTakeWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Подготовка данных
            var cars = new List<Car>()
            {
                new Car("Suzuki", "JP"),
                new Car("Toyota", "JP"),
                new Car("Opel", "DE"),
                new Car("Kamaz", "RUS"),
                new Car("Lada", "RUS"),
                new Car("Lada", "RUS"),
                new Car("Honda", "JP"),
            };
 
            Console.WriteLine("Пропустим японские машины в начале списка");
            var notJapanCars = cars.SkipWhile(car => car.CountryCode == "JP");
 
            foreach (var notJapanCar in notJapanCars)
                Console.WriteLine(notJapanCar.Manufacturer);
 
            Console.WriteLine();
 
            Console.WriteLine("Теперь выберем только японские машины из начала списка");
            var japanCars = cars.TakeWhile(car => car.CountryCode == "JP");
 
            foreach (var japanCar in japanCars)
                Console.WriteLine(japanCar.Manufacturer);

        }
    }
}