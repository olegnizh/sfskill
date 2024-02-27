using System;
using System.Linq;
using System.Text;

namespace LinqModule.Unit_0.ExtensionMethodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            string[] people = {"Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян"};
 
            var selectedPeople = people.Where(p => p.StartsWith("А")).OrderBy(p => p);
          
            foreach (string s in selectedPeople)
                Console.WriteLine(s);
        }
    }
}