using System;
using System.IO;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите путь до директории:");
            var path = Console.ReadLine();
            DeleteFiles(path);
            Console.ReadKey();
        }

        static void DeleteFiles(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Указанный путь не существует");
                return;
            }

            try
            {
                var directoryInfo = new DirectoryInfo(path);
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    if (file.LastAccessTime < (DateTime.Now - TimeSpan.FromMinutes(30)))
                    {
                        file.Delete();
                        Console.WriteLine($"Удален файл: {file.FullName} -> {file.LastAccessTime.ToString()}");
                    }
                }

                foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
                {
                    if (directory.LastAccessTime < (DateTime.Now - TimeSpan.FromMinutes(30)))
                    {
                        directory.Delete(true);
                        Console.WriteLine($"Удалена директория: {directory.FullName} -> {directory.LastAccessTime.ToString()}");
                    }
                    else
                        DeleteFiles(directory.FullName);
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine("Произошла ошибка!" + Environment.NewLine + exception.Message);
            }
        }
    }
}
