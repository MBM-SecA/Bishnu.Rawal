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
            foreach (var name in result4)
            {
                Console.WriteLine(name);
            }


           
            
            

        }
    }
}
