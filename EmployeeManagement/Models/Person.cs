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
    
    public Department Department { get; set; }
    public int DepartmentId { get; set; }
}