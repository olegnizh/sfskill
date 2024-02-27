using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CountExample.Models;

namespace CountExample
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
            
            // получим тех кто младше 25
            var youngStudentsAmount =
                ( from student in students
                    where student.Age < 25
                    select student).Count();
 
           
            Console.WriteLine(youngStudentsAmount);
            
            Console.WriteLine();
            Console.WriteLine("Теперь через методы-расширения:");
            Console.WriteLine();
            
            var youngStudentsAmount2 = students.Count(s => s.Age < 25);
 
            // тоже выведет 1
            Console.WriteLine(youngStudentsAmount2);
        }
    }
}