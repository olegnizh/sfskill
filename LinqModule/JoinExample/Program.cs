using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JoinExample.Models;

namespace JoinExample
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
            
            /* Соединим и сопоставим две коллекции: */
    
            var result = from car in cars // выберем машины
                join m in manufacturers on car.Manufacturer equals m.Name // соединим по общему ключу (имя производителя) с производителями
                select new //   спроецируем выборку в новую анонимную сущность
                {
                    Name = car.Model,
                    Manufacturer = m.Name,
                    Country = m.Country
                };
 
            // выведем результаты
            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Manufacturer} ({item.Country})");
            
            // То же самое - через метод-расширение!
            var result2 = cars.Join(manufacturers, // передаем в качестве параметра вторую коллекцию
                car => car.Manufacturer, // указываем общее свойство для первой коллекции
                m => m.Name, // указываем общее свойство для второй коллекции
                (car, m) =>
                    new // проекция в новый тип
                    {
                        Name = car.Model,
                        Manufacturer = m.Name,
                        Country = m.Country
                    });

        }
    }
}