using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqModule.Unit_0.ExtensionMethods.Models;

namespace LinqModule.Unit_0.ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /* Собрали для вас тут примеры использования методов-расширений. */
            /* Убирайте комментарии, вызывайте по одному и смотрите, как работают */
            
              // OrderByExample();
              // OrderByDescendingExample();
              // WhereExample();
              // AllExample();
              // AnyExample();
              // GroupByExample();
              // ThenByExample();
              // ThenByDescendingExample();
              // ReverseExample();
              // ContainsExample();
              // DistinctExample();
              // ExceptExample();
              // UnionExample();
              // IntersectExample();
              // CountExample();
              // SumExample();
              // AverageExample();
              // MinMaxExample();
              // TakeExample();
              // SkipExample();
              // TakeWhileExample();
              // SkipWhileExample();
              // ConcatExample();
              // ZipExample();
              // FirstExample();
              // FirstOrDefaultExample();
              // SingleExample();
              // SingleOrDefaultExample();
              // ElementAtExample();
              // LastExample();
        }

        /// <summary>
        /// Упорядочить элементы по возрвстанию
        /// </summary>
        static void OrderByExample()
        {
            var nums = new List<int>() {2, 9, 7};
            var orderedNums = nums.OrderBy(n => n);
 
            // вернeт 2, 7, 9
            foreach (var num in orderedNums)
                Console.WriteLine(num);
        }
        
        /// <summary>
        /// Упорядочить элементы по убыванию
        /// </summary>
        static void OrderByDescendingExample()
        {
            var nums = new List<int>() {2, 9, 7};
            var orderedNums = nums.OrderByDescending(n => n);
 
            // вернeт 9, 7, 2
            foreach (var num in orderedNums)
                Console.WriteLine(num);
        }
        
        /// <summary>
        /// Gпределяет фильтр выборки
        /// </summary>
        static void WhereExample()
        {
            var nums = new List<int>() {2, 9, 7};
            var lessThenFive = nums.Where(n => n < 5);
 
            // вернeт  2
            foreach (var num in lessThenFive)
                Console.WriteLine(num);
        }
        
        /// <summary>
        /// определяет, все ли элементы коллекции удовлетворяют определенному условию
        /// </summary>
        static void AllExample()
        {
            var nums = new List<int>() {2, 9, 7};
 
            if (nums.All(n => n < 5))
            {
                Console.WriteLine( "Все меньше пяти" );
            }
        }
        
        /// <summary>
        /// определяет, удовлетворяет ли хотя бы один элемент коллекции определенному условию
        /// </summary>
        static void AnyExample()
        {
            var nums = new List<int>() {2, 9, 7};
 
            if (nums.Any(n => n < 5))
            {
                Console.WriteLine( "Хотя бы один < 5" );
            }
        }
        
        /// <summary>
        /// группирует элементы по ключу
        /// </summary>
        static void GroupByExample()
        {
            var employees = new List<Employee>
            {
                new Employee {Name="Иван", Department= "Продажи" },
                new Employee {Name="Анна", Department="Продажи" },
                new Employee {Name="Кирилл", Department="Разработка" },
                new Employee {Name="Дмитрий", Department="Разработка" },
                new Employee {Name="Олег", Department="Разработка" },
            };
 
            // группируем сотрудников по департаменту
            var groups = employees
                .GroupBy(e => e.Department);
 
            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);
 
                foreach (var e in group)
                    Console.WriteLine(e.Name);
 
                Console.WriteLine();
            }
        }
        
        /// <summary>
        /// задает дополнительные критерии для упорядочивания элементов возрастанию
        /// </summary>
        static void ThenByExample()
        {
            var studentList  = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
            };
 
            var byNameAndAge = studentList
                // сортируем сначала по имени
                .OrderBy(s => s.StudentName)
                // потом по возрасту (по возрастанию)
                .ThenBy(s => s.Age);
            
            foreach (var stud in byNameAndAge)
                Console.WriteLine(stud.StudentName + " " + stud.Age);
        }
        
        /// <summary>
        /// задает дополнительные критерии для упорядочивания элементов по убыванию
        /// </summary>
        static void ThenByDescendingExample()
        {
            var studentList  = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
            };
 
            var byNameAndAge = studentList
                // сортируем сначала по имени
                .OrderBy(s => s.StudentName)
                // потом по возрасту (по убыванию)
                .ThenByDescending(s => s.Age);
            
            foreach (var stud in byNameAndAge)
                Console.WriteLine(stud.StudentName + " " + stud.Age);
        }

        /// <summary>
        /// располагает элементы в обратном порядке
        /// </summary>
        static void ReverseExample()
        {
            var nums = new List<int>() {2, 9, 7};
            nums.Reverse();

            foreach (var num in nums)
                Console.WriteLine(num);
        }

        /// <summary>
        /// определяет, содержит ли коллекция определенный элемент
        /// </summary>
        static void ContainsExample()
        {
            var nums = new List<int>() {2, 9, 7};
 
            if (nums.Contains(2))
            {
                Console.WriteLine("Нашли двойку");
            }
        }

        /// <summary>
        /// удаляет дублирующиеся элементы из коллекции
        /// </summary>
        static void DistinctExample()
        {
            var nums = new List<int>() {2, 9, 7 , 2};
            var uniqueNums = nums.Distinct();
 
            foreach (var number in uniqueNums)
                Console.WriteLine(number);
 
            // выведет 2, 9, 7
        }

        /// <summary>
        /// возвращает разность двух коллекциw, то есть те элементы, которые создаются только в одной коллекции
        /// </summary>
        static void ExceptExample()
        {
            var listOne = new List<int>() {7 , 2, 4, 11};
            var listTwo = new List<int>() {2, 9, 7 , 8, 0};
 
            var result = listOne.Except(listTwo);
 
            foreach (var number in result)
                Console.WriteLine(number);
 
            // выведет 4 и 11, так как их нет во второй коллекции
        }
        
        /// <summary>
        /// объединяет уникальные элементы двух однородных коллекций
        /// </summary>
        static void UnionExample()
        {
            var listOne = new List<int>() {7 , 2};
            var listTwo = new List<int>() {2, 9};
 
            var result = listOne.Union(listTwo);
 
            foreach (var number in result)
                Console.WriteLine(number);
 
            // выведет 7, 2, 9
        }

        /// <summary>
        /// возвращает пересечение двух коллекций, то есть те элементы, которые встречаются в обоих коллекциях
        /// </summary>
        static void IntersectExample()
        {
            var listOne = new List<int>() {7 , 2};
            var listTwo = new List<int>() {2, 9};
 
            var result = listOne.Intersect(listTwo);
 
            foreach (var number in result)
                Console.WriteLine(number);
 
            // выведет общий элемент для обеих коллекций - 2
        }

        /// <summary>
        /// подсчитывает количество элементов коллекции, которые удовлетворяют определенному условию
        /// </summary>
        static void CountExample()
        {
            var listOne = new List<int>() {7 , 2, 57, 8};
 
            var result = listOne.Count(e => e < 10);
 
            Console.WriteLine($"Количество элементов меньше 10: {result}");
            // Выведет 3
        }

        /// <summary>
        /// подсчитывает сумму числовых значений в коллекции
        /// </summary>
        static void SumExample()
        {
            var listOne = new List<int>() {7 , 2, 57, 8};
            var sum = listOne.Sum();

            Console.WriteLine(sum);
            // Выведет 74
        }

        /// <summary>
        /// подсчитывает cреднее значение числовых значений в коллекции
        /// </summary>
        static void AverageExample()
        {
            var listOne = new List<int>() {7 , 2, 57, 8};
            var average = listOne.Average();
            // Выведет среднее арифметическое  ( 18.5 )
            Console.WriteLine(average);
        }

        /// <summary>
        /// находит минимальное и максимальное значения соответственно
        /// </summary>
        static void MinMaxExample()
        {
            var listOne = new List<int>() {7 , 2, 57, 8};
 
            Console.WriteLine(listOne.Min()); // 2
            Console.WriteLine(listOne.Max()); // 57
        }
        
        /// <summary>
        /// выбирает определенное количество элементов
        /// </summary>
        static void TakeExample()
        {
            var listOne = new List<int>() {7 , 2, 57, 8};
 
            var res = listOne.Take(2);
            // выберет первые два элемента (7 и 2)

            foreach (var e in res)
                Console.WriteLine(e);
        }

        /// <summary>
        /// пропускает определенное количество элементов
        /// </summary>
        static void SkipExample()
        {
            var listOne = new List<int>() {7 , 2, 57, 8};
 
            var res = listOne.Skip(1);
            // пропустит 1 элемент  (получит 2, 57, 8)

            foreach (var e in res)
                Console.WriteLine(e);
        }

        /// <summary>
        /// возвращает цепочку элементов последовательности, до тех пор, пока условие истинно
        /// </summary>
        static void TakeWhileExample()
        {
            var listOne = new List<int>() {7 , 2, 57, 8};
             
            var res = listOne.TakeWhile( e => e < 10 );
            // будет возвращать новые элементы коллекции до тех пор, пока не встретит тот, для которого условие не выполнится (в выборку попадут только 7 и 2)
            
            foreach (var e in res)
                Console.WriteLine(e);
        }
        
        /// <summary>
        ///  пропускает элементы в последовательности, пока они удовлетворяют заданному условию, и затем возвращает оставшиеся элементы
        /// </summary>
        static void SkipWhileExample()
        {
            var listOne = new List<int>() {7 , 2, 57, 8};
 
            var res = listOne.SkipWhile( e => e < 10 );
            // пропустит все элементы до первого, который удовлетворит условию
            
            foreach (var e in res)
                Console.WriteLine(e);
        }

        /// <summary>
        /// объединяет две коллекции
        /// </summary>
        static void ConcatExample()
        {
            var listOne = new List<int>() {7 , 2, };
            var listTwo = new List<int>() { 2,  8};
 
            var concatenation = listOne.Concat(listTwo);
            // выведет 7, 2, 2, 8 (т.е. допускает повторяющиеся элементы)
            
            foreach (var e in concatenation)
                Console.WriteLine(e);
        }

        /// <summary>
        /// объединяет две коллекции в соответствии с определенным условием
        /// </summary>
        static void ZipExample()
        {
            var listOne = new List<int>() {7 , 2, };
            var listTwo = new List<int>() { 2,  8};
 
            var result = listOne.Zip(listTwo, (a, b) => a + b);
 
            // объединяет элементы коллекций, выполняя определенные действия
            // здесь - попарное сложение, в результате 9 и 10

            foreach (var e in result)
                Console.WriteLine(e);
        }
        
        /// <summary>
        /// выбирает первый элемент коллекции, удовлетворяющий условию
        /// </summary>
        static void FirstExample()
        {
            var listOne = new List<int>() {7 , 2, };
            Console.WriteLine(listOne.First()); 
            
            // получим 7
        }
        
        /// <summary>
        /// выбирает первый элемент коллекции, удовлетворяющий условию, или возвращает значение по умолчанию
        /// </summary>
        static void FirstOrDefaultExample()
        {
            var listOne = new List<int>() {7 , 2, 4, 10 };
            Console.WriteLine(listOne.FirstOrDefault(a => a < 7)); 
            
            // получим 2, но если бы ничего не нашлось - вернуло бы 0
        }

        /// <summary>
        /// выбирает единственный элемент коллекции, если коллекция содержит больше или меньше одного элемента, удовлетворяющего условию, то генерируется исключение
        /// </summary>
        static void SingleExample()
        {
            string[] students = { "Оля", "Иван", "Сергей",
                "Бонифаций"};
 
            string firstWithLongName = students.Single(student => student.Length > 8);
 
            Console.WriteLine(firstWithLongName);
            
            // Бонифаций
        }

        /// <summary>
        /// выбирает первый элемент коллекции или возвращает значение по умолчанию
        /// </summary>
        static void SingleOrDefaultExample()
        {
            string[] students = { "Оля", "Иван", "Сергей", "Бонифаций"};
            string firstWithLongName = students.SingleOrDefault(student => student.Length > 10);
 
            Console.WriteLine(firstWithLongName);
            // Здесь вернет null, так как это значение по умолчанию для типа String
        }

        /// <summary>
        /// выбирает элемент последовательности по определенному индексу
        /// </summary>
        static void ElementAtExample()
        {
            var listOne = new List<int>() {7 , 2, 4, 10 };
            var second = listOne.ElementAt(1);
            Console.WriteLine(second);
            // получим 2
        }

        /// <summary>
        /// выбирает последний элемент коллекции
        /// </summary>
        static void LastExample()
        {
            var listOne = new List<int>() {7 , 2, };
            Console.WriteLine(listOne.Last()); 
            // получим 2
        }

        /// <summary>
        /// выбирает последний элемент коллекции или возвращает значение по умолчанию
        /// </summary>
        static void LastOrDefaultExample()
        {
            var emptyList = new List<int>() {};
            Console.WriteLine(emptyList.LastOrDefault()); 
            
            // получим 0, так как это значение по умолчанию для типа int
        }
    }
}