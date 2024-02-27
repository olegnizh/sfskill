using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InstantExecuting.Models;

namespace InstantExecuting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            var  students = new List<Student>
            {
                new Student { Name="Андрей", Age=23 },
                new Student { Name="Сергей", Age=27 },
                new Student { Name="Дмитрий", Age=29 }
            };
            
            // здесь запрос будет выполнен немедленно, и в переменную будет сохранено количество элементов выборки
            var youngStudentsAmount = (from s in students where s.Age < 25 select s).Count();
            Console.WriteLine(youngStudentsAmount);
        
            // ещё один пример мгновенного выполнения - сохранение рещультата выборки в новую коллекцию
            var youngStudents = students
                .Where(s => s.Age < 25) // на этом этапе происходит генерация LINQ-выражения
                .ToList(); // А вот тут уже будет выполнение
        }
    }
}