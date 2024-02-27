using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GroupJoinExample.Models;

namespace GroupJoinExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Список моделей
            var cars = new List<Car>()
            {
                new Car() { Model  = "SX4", Manufacturer = "Suzuki"},
                new Car() { Model  = "Grand Vitara", Manufacturer = "Suzuki"},
                new Car() { Model  = "Jimny", Manufacturer = "Suzuki"},
                new Car() { Model  = "Land Cruiser Prado", Manufacturer = "Toyota"},
                new Car() { Model  = "Camry", Manufacturer = "Toyota"},
                new Car() { Model  = "Polo", Manufacturer = "Volkswagen"},
                new Car() { Model  = "Passat", Manufacturer = "Volkswagen"},
            };
 
            // Список автопроизводителей
            var manufacturers = new List<Manufacturer>()
            {
                new Manufacturer() { Country = "Japan", Name = "Suzuki" },
                new Manufacturer() { Country = "Japan", Name = "Toyota" },
                new Manufacturer() { Country = "Germany", Name = "Volkswagen" },
            };
            
            // Выборка + группировка
            var result2 =  manufacturers.GroupJoin(
                cars, // первый набор данных
                m => m.Name, // общее свойство второго набора
                car  => car.Manufacturer, // общее свойство первого набора
                (m, crs ) => new  // результат выборки
                {
                    Name = m.Name,
                    Country = m.Country,
                    Cars = crs.Select(c=>c.Model)
                });
 
            // Вывод:
            foreach (var team in result2)
            {
                Console.WriteLine(team.Name + ":");
  
                foreach (string car in team.Cars)
                    Console.WriteLine(car);
  
                Console.WriteLine();
            }
        }
    }
}
