using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Department
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }

    [Required]
    public string Code { get; set; }

    public string Description { get; set; }
    public DateTime StartDate { get; set; }

    public List<Person> People { get; set; }
}