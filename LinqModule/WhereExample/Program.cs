using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqModule.Unit_1.WhereExample.Models;

namespace LinqModule.Unit_1.WhereExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Добавим Россию с её городами
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));
            
            // Выберем города - миллионники:
            var bigCities = from russianCity in russianCities
                where russianCity.Population > 1000000
                orderby russianCity.Population descending
                select russianCity;
 
            foreach (var bigCity in bigCities)
                Console.WriteLine(bigCity.Name + " - " + bigCity.Population);

            Console.WriteLine();
            Console.WriteLine("То же с помощью методов-расширений: ");
            Console.WriteLine();
            
            var bigCities2 = russianCities.Where(c => c.Population > 1000000)
                .OrderByDescending(c => c.Population);
            
            foreach (var bigCity in bigCities2)
                Console.WriteLine(bigCity.Name + " - " + bigCity.Population);
        }
    }
}