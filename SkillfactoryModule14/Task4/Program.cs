namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

            List<string> sortedList = new();

            foreach (string person in people)
            {
                if (person.StartsWith("А"))
                    sortedList.Add(person);
            }

            sortedList.Sort();

            foreach (string person in sortedList)
                Console.WriteLine(person);
        }
    }
}