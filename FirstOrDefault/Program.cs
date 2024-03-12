using System;
using System.Collections.Generic;
using System.Linq;


namespace FirstOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: this List has 3 elements.
            var list = new List<string>() { "Cat", "Rat", "Mouse" };
            Console.WriteLine(list.FirstOrDefault());

            // Part 2: this query produces no results so FirstOrDefault is null.
            var query1 = from element in list
                         where element.Length > 10
                         select element;
            Console.WriteLine(query1.FirstOrDefault() == null);

            // Part 3: this query produces one result, so FirstOrDefault is a string.
            var query2 = from element in list
                         where element.Length > 3
                         select element;
            Console.WriteLine(query2.FirstOrDefault());

            // Part 4: this array has no elements, so FirstOrDefault is zero.
            int[] array = new int[0];
            Console.WriteLine(array.FirstOrDefault());
        }

    }

}
