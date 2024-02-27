namespace Task14_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, string[]>();

            companies.Add("Apple", new[] { "Mobile", "Desktop" });
            companies.Add("Samsung", new[] { "Mobile" });
            companies.Add("IBM", new[] { "Desktop" });

            var result = companies.Where(c => c.Value.Contains("Mobile"));

            foreach (var item in result)
                Console.WriteLine(item.Key);
        }
    }
}