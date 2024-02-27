using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;

            Console.WriteLine("Введите предложение : ");

            s1 = Console.ReadLine();

            Console.WriteLine(counting.CountStringOccurrences(s1, "всех")); //ввод слова и поиск его дубликатов

            Console.ReadLine();

        }

        public static class counting

        {

            public static int CountStringOccurrences(string text, string pattern)

            {

                int count = 0;

                int i = 0;

                while ((i = text.IndexOf(pattern, i)) != -1)

                {

                    i += pattern.Length;

                    count++;

                }

                return count;

            }



        }

    }
}
