using System;
using System.Linq;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

            var selectedPeople = from p in people // промежуточная переменная p 
                                 where p.StartsWith("А") // фильтрация по условию
                                 orderby p // сортировка по возрастанию (дефолтная)
                                 select p; // выбираем объект и сохраняем в выборку

            foreach (string s in selectedPeople)
                Console.WriteLine(s);
        }
    }
}
