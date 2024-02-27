namespace Task14_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = { "Раз два три","четыре пять шесть","семь восемь девять" };

            var res = from t in text
                      from word in t.Split(" ")
                      select word;

            foreach (var s in res)
            {
                Console.WriteLine(s);
            }
        }
    }
}