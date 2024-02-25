using System;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace DictionaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим словарь. Ключом будет строка, а значением - массив строк
            var cities = new Dictionary<string, string[]>(3 /* Размер (указывать необязательно))*/ );

            // Добавим новые значения
            cities.Add("Россия", new[] { "Москва", "Санкт-Петербург", "Волгоград" });
            cities.Add("Украина", new[] { "Киев", "Львов", "Николаев", "Одесса" });
            cities.Add("Беларусь", new[] { "Минск", "Витебск", "Гродно" });
            //  Посмотрим всё что есть в словаре
            foreach (var citiesByCountry in cities)
            {
                Console.Write(citiesByCountry.Key + ": ");
                foreach (var city in citiesByCountry.Value)
                    Console.Write(city + " ");

                Console.WriteLine();
            }

            Console.WriteLine();

            // Теперь попробуем вывести значения по ключу
            var russianCities = cities["Россия"];
            Console.WriteLine("Города России:");
            foreach (var city in russianCities)
                Console.WriteLine(city);
        }
    }
}