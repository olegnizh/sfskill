using System;
using System.Linq;
using System.Text;

namespace LinqModule.Unit_0.SimpleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            string[] people = {"Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян"};
 
            var selectedPeople = from p in people // промежуточная переменная p 
                where p.ToUpper().StartsWith("А") // фильтрация по условию
                orderby p  // сортировка по возрастанию (дефолтная)
                select p; // выбираем объект и сохраняем в выборку
 
            foreach (string s in selectedPeople)
                Console.WriteLine(s);
        }
    }
}
