using System;
using System.Linq;
using System.Text;

namespace AggregateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            int[] numbers = { 1, 2, 3, 4, 5};
            int result = numbers.Aggregate((x,y)=> x - y);
 
            // вычислит 1-2-3-4-5 = -13
            Console.WriteLine(result);
        }
    }
}