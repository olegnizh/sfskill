namespace Task14_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            var orderedWords = words.OrderBy(x=>x.Length).Select(x=>
            new
            {
                Word = x
            });

            foreach(var word in orderedWords)
            {
                Console.WriteLine(word.Word);
            }
        }
    }
}