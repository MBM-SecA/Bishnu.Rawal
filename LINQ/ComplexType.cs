using System.Linq;
public class ComplexType
{
    public void LearnLINQ()
    {
         var countries = Country.GetCountries();

            var asianCountries = from country in countries
                                 where country.Continent == "Asia"
                                 select country;

            // HW1 : List coutries in Europe which have population less than 100k
            // HW2 : List asian coutries which are not ever invaded.

            var result5 = from country in countries
                          where country.Continent == "Europe" && country.Population < 100000
                          select country;

            var result6 = from c in countries
                          where c.Continent == "Asia" && c.IndependenceDay == default
                          select c;

            // HW - Is there any african country in your coutry collection
            // HW - Print first 2 largest asian country names.
    }
}