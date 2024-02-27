namespace Task14_2_3
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

            var youngStudents = from s in students
                                where s.Age <= 27
                                let yearOfBirh = DateTime.Now.Year - s.Age
                                select new Application
                                {
                                    Name = s.Name,
                                    YearOfBirth = yearOfBirh
                                };

            foreach(var student in youngStudents )
            {
                Console.WriteLine(student.Name + " "+ student.YearOfBirth);
            }
        }
    }
}