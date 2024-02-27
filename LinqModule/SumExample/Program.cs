using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SumExample.Models;

namespace SumExample
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
            
            var simpleNumbers = new[] {3, 5, 7};
 
            // Вернет 15
            Console.WriteLine(simpleNumbers.Sum());
        }
    }
}