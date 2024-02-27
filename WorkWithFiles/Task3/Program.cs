using System;
using System.IO;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите путь до директории:");
            var path = Console.ReadLine();
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Указанный путь не существует");
                return;
            }
            var startSize = CalculateDirectorySize(path);
            Console.WriteLine($"Исходный размер папки: {startSize} байт");
            var filesDeleted = DeleteFiles(path);
            var endSize = CalculateDirectorySize(path);
            Console.WriteLine($"Освобождено: {startSize - endSize} байт, удалено {filesDeleted} файлов");
            Console.WriteLine($"Текущий размер папки: {endSize} байт");
            Console.ReadKey();
        }

        private static int DeleteFiles(string path)
        {
            try
            {
                int deletedFiles = 0;
                var directoryInfo = new DirectoryInfo(path);
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    if (file.LastAccessTime < (DateTime.Now - TimeSpan.FromMinutes(5)))
                    {
                        file.Delete();
                        ++deletedFiles;
                    }
                }

                foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
                {
                    if (directory.LastAccessTime < (DateTime.Now - TimeSpan.FromMinutes(5)))
                    {
                        directory.Delete(true);
                    }
                    else
                        DeleteFiles(directory.FullName);
                }
                return deletedFiles;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Произошла ошибка!" + Environment.NewLine + exception.Message);
                return 0;
            }
        }

        private static long CalculateDirectorySize(string path)
        {
            try
            {
                long size = 0;
                var directoryInfo = new DirectoryInfo(path);
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    size += file.Length;
                }
                foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
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
