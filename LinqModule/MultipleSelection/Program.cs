using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqModule.Unit_2.MultipleSelection.Models;

namespace LinqModule.Unit_2.MultipleSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Список студентов
            var  students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
            };
 
            // Список курсов
            var coarses = new List<Coarse>
            {
                new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
                new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };
            
            // добавим студентов в курсы
            var studentsWithCoarses = from stud in students
                from coarse in coarses
                select new { Name = stud.Name, CoarseName = coarse.Name };
 
            // выведем результат
            foreach (var stud in studentsWithCoarses)
                Console.WriteLine($"Студент {stud.Name} добавлен курс {stud.CoarseName}");
        }
    }
}