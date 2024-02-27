using System;
using System.Linq;
using System.Text;

namespace LinqModule.Unit_1.SimpleWhereExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            
            var evenNums = from i in numbers
                where i%2==0 && i>10
                select i;
      
            foreach (int i in evenNums)
                Console.WriteLine(i);
        }
    }
}