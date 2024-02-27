using System;
using System.Linq;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("kkk.txt");
            var allwords = text.Split(' ');
            var unique =
               (from word in allwords select word.ToLower()).Distinct().OrderBy(name => name);
            foreach (var word in unique)
            {
                int cnt = (from word2 in allwords where word2.ToLower() == word select word2).Count();
                Console.WriteLine("Word: {0} - {1}", word, cnt);
            }
            Console.ReadLine();
        }
    }
           

}

       

