using System;

namespace EnumsAndProperties
{
    enum DayWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    internal class Demo
    {
        public DayWeek DayOfWeek { get; set; }
        void PrintGreetings()
        {
            if (DayOfWeek == DayWeek.Saturday)
            {
                Console.WriteLine("Its a good saturaday");
            }
            else if (DayOfWeek == DayWeek.Sunday)
            {
                Console.WriteLine("Its yet another weekend day.");
            }
            else
            {
                Console.WriteLine("Oh gosh, work day.");
            }
        }
    }

}