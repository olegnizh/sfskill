using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaxMinAvgExample.Models;

namespace MaxMinAvgExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            var nums = new [] { 1, 7, 45, 23 };

            Console.WriteLine("Проверим на простых числах");

            Console.WriteLine("Наибольшее: " + nums.Max());
            Console.WriteLine("Наименьшее: " + nums.Min());
            Console.WriteLine("Среднее: " + nums.Average());

          
            Console.WriteLine();
            Console.WriteLine("Теперь посложнее");
            
            var  students = new List<Student>
            {
                new Student {Name="Андрей", Age=23 },
                new Student {Name="Сергей", Age=27 },
                new Student {Name="Дмитрий", Age=29 }
            };
 
            // найдем возраст самого старого студента ( 29 )
            var oldest = students.Max(s => s.Age);
            Console.WriteLine("Максимальный возраст студента: " + oldest);
 
            // самого молодого ( 23 )
            var youngest = students.Min(s => s.Age);
            Console.WriteLine("Минимальный возраст студента: " + youngest);
 
            //  и средний возраст ( 26,3 )
            var average = students.Average(s => s.Age);
            Console.WriteLine("Средний возраст студента: " + average);
        }
    }
}