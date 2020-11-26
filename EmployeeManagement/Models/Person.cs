using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "We need last name.")]
    [Display(Name = "Last Name")]
    public string Surname { get; set; }
    
    public string Address { get; set; }
    public char? Gender { get; set; } = 'M';
    public double? Salary { get; set; }

    public static List<Person> GetEmployees()
    {
        // Object initializer syntax
        Person empl1 = new Person() { Id = 1, FirstName = "Bishnu", Surname = "Rawal", Address = "Kathmandu", Salary = 200.0 };
        Person empl2 = new Person() { Id = 2, FirstName = "Ram", Surname = "Rawal", Address = "Bhaktapur", Salary = 208790.0 };
        Person empl3 = new Person() { Id = 3, FirstName = "Ramesh", Surname = "Rawal1", Address = "Kathmandu2", Salary = 23200.0 };
        Person empl4 = new Person() { Id = 4, FirstName = "James", Surname = "Rawal1", Address = "Kathmandu3", Salary = 20122130.0 };
        Person empl5 = new Person() { Id = 5, FirstName = "Lily", Surname = "Rawal", Address = "Kathmand4", Salary = 20045345.0 };
        Person empl6 = new Person() { Id = 6, FirstName = "Bernard", Surname = "Rawal", Address = "Kathmandu5", Salary = 2045350.0 };

        List<Person> employees = new List<Person>() { empl1, empl2, empl3, empl4, empl5, empl6 };

        return employees;
    }
}