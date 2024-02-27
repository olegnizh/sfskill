using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите путь до файла Students.dat: ");
            var filePath = Console.ReadLine();
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Указанный путь не существует");
                return;
            }
            Console.Write("Укажите директорию для записи ответа: ");
            var destinationPath = Console.ReadLine();
            if (!Path.IsPathRooted(destinationPath))
            {
                Console.WriteLine("Указанный путь не существует");
                return;
            }
            ParseFile(filePath, destinationPath);
            Console.ReadKey();
        }

        private static void ParseFile(string filePath, string destinationPath)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Student[] students = null;
                using (var reader = new FileStream(filePath, FileMode.Open))
                {
                    students = (Student[]) formatter.Deserialize(reader);
                }

                if (!Directory.Exists(destinationPath))
                    Directory.CreateDirectory(destinationPath);

                var directoryInfo = new DirectoryInfo(destinationPath);
                foreach(Student student in students)
                {
                    var fileName = directoryInfo.FullName + "\\" + student.Group + ".txt";
                    var fileInfo = new FileInfo(fileName);

                    using (var writer = fileInfo.AppendText())
                    {
                        writer.WriteLine($"{student.Name} - {student.DateOfBirth}");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Произошла ошибка!" + Environment.NewLine + exception.Message);
            }
        }
    }
}
