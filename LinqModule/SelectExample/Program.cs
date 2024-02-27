using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqModule.Unit_1.SelectExample.Models;

namespace LinqModule.Unit_1.SelectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Подготовим данные
            List<Student> students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };
 
            var names = from s in students select s.Name;
          
            // Выведем результат простой выборки
            foreach (var name in names)
                Console.WriteLine(name);
            
            Console.WriteLine();

            Console.WriteLine("Выборка с использованием SQL-подобного синтаксиса: ");
            Console.WriteLine();
            UseSqlSyntax(students);
            
            Console.WriteLine();
            
            Console.WriteLine("Выборка с использованием методов-раширений: ");
            Console.WriteLine();
            UseExtensionMethods(students);
        }

        static void UseSqlSyntax( List<Student> students )
        {
            var studentApplicationsAnonymousType = from s in students
                // создадим анонимный тип для представления анкеты
                select new
                {
                    FirstName = s.Name,
                    YearOfBirth = DateTime.Now.Year - s.Age
                };
            
            // Выведем результат выборки в анонимный тип
            foreach (var application in studentApplicationsAnonymousType)
                Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");

            Console.WriteLine();
            
            var studentApplications = from s in students
                // спроецируем в новую сущеность анкеты
                select new Application()
                {
                    FirstName = s.Name,
                    YearOfBirth = DateTime.Now.Year - s.Age
                };
            
            // Выведем результат выборки в объекты класса
            foreach (var application in studentApplications)
                Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");
        }
        
        static void UseExtensionMethods( List<Student> students )
        {
            // выборка имен в строки
            var names = students.Select(u => u.Name);
 
            // проекция в анонимный тип
            var applications = students.Select(u => new
            {
                FirstName = u.Name,
                YearOfBirth = DateTime.Now.Year - u.Age
            });
            
            // Выведем результат выборки в анонимный тип
            foreach (var application in applications)
                Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");
            
            Console.WriteLine();
 
            // проекция в другой тип
            var applications1 = students.Select(u => new Application()
            {
                FirstName = u.Name,
                YearOfBirth = DateTime.Now.Year - u.Age
            });
            
            // Выведем результат выборки в анонимный тип
            foreach (var application in applications1)
                Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");
        }
    }
}