using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleSorting.Models;

namespace SimpleSorting
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
            
            // Сортировка по возрасту
            var sortedStuds = from s in students orderby s.Age select s;
 
            foreach (var stud in sortedStuds)
                Console.WriteLine(stud.Name + ", " + stud.Age);

            Console.WriteLine();
            
            // Сортировка по убыванию возраста
            var sortedStudsDesc = from s in students orderby s.Age descending select s;

            foreach (var stud in sortedStudsDesc)
                Console.WriteLine(stud.Name + ", " + stud.Age);

            Console.WriteLine();
            Console.WriteLine("То же самое через методы - расширения:");
            Console.WriteLine();
            
            //  По возрастанию
            var sortedStudentsAsc = students.OrderBy(s => s.Age);
            foreach (var stud in sortedStudentsAsc)
                Console.WriteLine(stud.Name + ", " + stud.Age);

            Console.WriteLine();
          
            //  По убыванию
            var sortedStudentsDesc = students.OrderByDescending(s => s.Age);
            foreach (var stud in sortedStudentsDesc)
                Console.WriteLine(stud.Name + ", " + stud.Age);
        }
    }
}