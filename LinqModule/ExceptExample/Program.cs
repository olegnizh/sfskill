using System;
using System.Linq;
using System.Text;

namespace ExceptExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Список напитков в продаже
            string[] drinks = { "Вода", "Кока-кола", "Лимонад" , "Вино"};
            // Алкогольные напитки
            string[] alcohol = { "Вино", "Пиво", "Сидр"};
 
            // Убираем алкоголь из ассортимента
            var drinksForKids = drinks.Except(alcohol);
 
            foreach (string drink in drinksForKids)
                Console.WriteLine(drink);
        }
    }
}