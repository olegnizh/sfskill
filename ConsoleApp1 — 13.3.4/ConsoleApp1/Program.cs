using System;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {

            var phoneBook = new List<Contact>();
            phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));
            phoneBook.Add(new Contact("Андрей", 79990000001, "andrew@example.com"));

            Console.WriteLine("Введите имя");
            string sname = Console.ReadLine();
            Console.WriteLine("Введите телефон");
            string sfone = Console.ReadLine();
            Console.WriteLine("Введите почту");
            string smail = Console.ReadLine();
            Contact newContact = new Contact(sname,Convert.ToInt32(sfone),smail);


            AddUnique(newContact, phoneBook);
            

        }

        private static void AddUnique(Contact newContact, List<Contact> phoneBook)
        {
            bool alreadyExists = false;

            // пробегаемся по списку и смотрим, есть ли уже с таким именем
            foreach (var contact in phoneBook)
            {
                if (contact.Name == newContact.Name)
                {
                    //  если вдруг находим  -  выставляем флаг и прерываем цикл
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
                phoneBook.Add(newContact);

            //  сортируем список по имени
            phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

            foreach (var contact in phoneBook)
                Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
        }

        public class Contact // модель класса
        {
            public Contact(string name, long phoneNumber, String email) // метод-конструктор
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Email = email;
            }

            public String Name { get; }
            public long PhoneNumber { get; }
            public String Email { get; }
        }

    }

}
