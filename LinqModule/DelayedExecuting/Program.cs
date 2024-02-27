using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DelayedExecuting.Models;

namespace DelayedExecuting
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
 
            var youngStudents = from s in students where s.Age < 25 select s;
            
            // Запрос, написанный выше, будет выполнен лишь когда мы обратимся к результатам нашей выборки, например в цикле: 
            
            foreach (var stud in youngStudents)
                Console.WriteLine(stud.Name);
        }
    }
}