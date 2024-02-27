namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>() { 1, "Сергей", "Андрей", 300 };
            
            //1
            var sortedNames = from o in objects
                              where o is string
                              orderby o
                              select o;

            foreach (var name in sortedNames)
                Console.WriteLine(name);

            Console.WriteLine();

            //2
            foreach (var name in objects.Where(o => o is string).OrderBy(o => o))
                Console.WriteLine(name);
        }
    }
}