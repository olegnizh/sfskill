namespace Task14_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            var smallCities = russianCities.Where(c => c.Name.Length < 11).OrderBy(c=>c.Name.Length);

            foreach (var city in smallCities)
                Console.WriteLine(city.Name);
        }
    }
}