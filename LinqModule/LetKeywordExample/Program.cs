using System;
using System.Collections.Generic;
using LinqModule.Unit_1.LetKeywordExample.Models;
using System.Linq;
using System.Text;

namespace LinqModule.Unit_1.LetKeywordExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Наш список студентов
            List<Student> students = new List<Student>
            {
                new Student {Name = "Андрей", Age = 23, Languages = new List<string> {"английский", "немецкий"}},
                new Student {Name = "Сергей", Age = 27, Languages = new List<string> {"английский", "французский"}},
                new Student {Name = "Дмитрий", Age = 29, Languages = new List<string> {"английский", "испанский"}},
                new Student {Name = "Василий", Age = 24, Languages = new List<string> {"испанский", "немецкий"}}
            };
            
            var fullNameStudents = from s in students
            let fullName = s.Name + " Иванов" // временная переменная для генерации полного имени
            select new // проекция в новую сущность с использованием новой переменной
            {
                Name = fullName,
                Age = s.Age
            };
 
            foreach (var stud in fullNameStudents)
                Console.WriteLine(stud.Name + ", " + stud.Age);
        }
    }
}