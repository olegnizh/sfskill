using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MultipleSorting.Models;

namespace MultipleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Список студентов
            var  students = new List<Student>
            {
                new Student {Name="Алёна", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Яков", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };
            
            // Сортировка сначала по имени, а затем - по возрасту
            var sortedStuds = from s in students orderby s.Name, s.Age select s;
          
            foreach (var stud in sortedStuds)
                Console.WriteLine(stud.Name + ", " + stud.Age);

            Console.WriteLine();
            Console.WriteLine("То же самое через методы-расширения:");
            Console.WriteLine();
            
            // Сортировка по  имени и возрасту (возрастание)
            var sortedStuds2 = students
                .OrderBy(s => s.Name)
                .ThenBy(s => s.Age);
          
            foreach (var stud in sortedStuds2)
                Console.WriteLine(stud.Name + ", " + stud.Age);
            
            Console.WriteLine();
            
            // Сортировка по  имени и возрасту (убывание)
            var sortedStudsDesc2 = students
                .OrderByDescending(s => s.Name)
                .ThenByDescending(s => s.Age);
            
            foreach (var stud in sortedStudsDesc2)
                Console.WriteLine(stud.Name + ", " + stud.Age);
            
        }
    }
}