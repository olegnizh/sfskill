using System.Runtime.InteropServices;
using Task14_2_3;

namespace Task14_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var coarses = new List<Coarse>
            {
                new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
                new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };

            var courceStrudents = from student in students
                                  where student.Age < 29
                                  where student.Languages.Contains("английский")
                                  let yearOfBirh = DateTime.Now.Year - student.Age
                                  from cource in coarses
                                  where cource.Name.Contains("C#")
                                  select new { Name = student.Name, Year = yearOfBirh, CourceName = cource.Name };

            foreach( var course in courceStrudents)
                Console.WriteLine(course.Name +" "+ course.Year +" "+course.CourceName);

        }
    }
}