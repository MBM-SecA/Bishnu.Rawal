using System;
using System.Collections.Generic;

public class Country
{
    public string Name { get; set; }
    public string Continent { get; set; }
    public double Area { get; set; }
    public long Population { get; set; }
    public DateTime IndependenceDay { get; set; }

    public Country(string n, string c, double a, long p, DateTime i = default)
    {
        Name = n;
        Continent = c;
        Area = a;
        Population = p;
        IndependenceDay = i;
    }

    public static List<Country> GetCountries()
    {
        Country c1 = new Country("Nepal", "Asia", 23423.45, 324242324);
        Country c2 = new Country("India", "Asia", 23423.45, 324242324, DateTime.Parse("1947/1/1"));
        Country c3 = new Country("Russia", "Europe", 23423.45, 324242324);
        Country c4 = new Country("USA", "North America", 23423.45, 324242324);
        Country c5 = new Country("Canada", "North America", 23423.45, 324242324);
        Country c6 = new Country("Bhutan", "Asia", 23423.45, 324242324);

        var countries = new List<Country> { c1, c2, c3, c4, c5, c6 };

        return countries;
    }
}