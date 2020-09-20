using System;

namespace AllAboutClasses
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public readonly double AREA = 43443.45;
        public static readonly bool IsOnEarth;

        // Instance Constructors
        // Default contructor
        public Country() 
        {

        }

        // Parameterized constructor
        public Country(string name)
        {
            Name = name;
        }

        public Country(string name, int population, double area)
        {
            Name = name;
            Population = population;
            AREA = area;
        }  

        // Static Contructor    
        static Country()
        {
            IsOnEarth = true;
        }

        // Finalizer
        ~Country()
        {
            Console.WriteLine("I am dying...");
        }
    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal");
        }
    }
}