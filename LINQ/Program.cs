using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            // LINQ - Language Integrated Query

            int[] numbers = { 23, 34, 56, 12, 23, 89, 67, 10, 110, 334, 1, 2, 3, 45, 73, 11, 20 };

            // Fetch numbers which are greater than 50 and less than 70

            // Using method syntax - lambda expression
            var result1 = numbers.Where(x => x > 50 && x < 70);

            // Using sql query syntax - query expression
            var result2 = from x in numbers
                          where x > 50 && x < 70
                          select x;

            string[] names = { "bisnu", "abc", "ram", "ramesh", "james", "ronald", "Raygon", "Ramsy" };

            // Names having length > 3 and starts with letter 'R'
            var result3 = names.Where(y => y.Length > 3 && y.StartsWith("r"));


            var result4 = from y in names
                          where y.Length > 3 && y.ToUpper().StartsWith("R")
                          select y;

            // Projections
            var result5 = from num in numbers
                          select num * num;

            // Ordering
            var result6 = from num in numbers
                          orderby num
                          select num;
            
            // Partitioning
            var result7 = numbers.Skip(5).Take(5);

            // Quantifier
            var result8 = numbers.Any(x => x % 2 == 0);
            var result9 = numbers.All(x => x % 2 == 0);
            var result10 = numbers.Contains(34);

            var result11 = Enumerable.Range(1, 1000);
            var result12 = Enumerable.Repeat("Hello World!", 10);

            foreach (var num in result12)
            {
                Console.WriteLine(num);
            }
        }
    }
}
