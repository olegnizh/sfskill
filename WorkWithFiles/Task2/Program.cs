using System;
using System.IO;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите путь до директории: ");
            var path = Console.ReadLine();
            var size = CalculateDirectorySize(path);
            Console.WriteLine($"Размер папки {size} байт");
            Console.ReadKey();
        }

        private static long CalculateDirectorySize(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Указанный путь не существует");
                return 0;
            }

            try
            {
                long size = 0;
                var directoryInfo = new DirectoryInfo(path);
                foreach(FileInfo file in directoryInfo.GetFiles())
                {
                    size += file.Length;
                }
                foreach(DirectoryInfo directory in directoryInfo.GetDirectories())
                {
                    size += CalculateDirectorySize(directory.FullName);
                }
                return size;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Произошла ошибка!" + Environment.NewLine + exception.Message);
                return 0;
            }
        }
    }
}
