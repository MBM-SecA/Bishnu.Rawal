using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var employees = Person.GetEmployees();
        return View(employees);
    }
    
    public ActionResult Detail([FromQuery] int id)
    {        
        var employees = Person.GetEmployees();
        Person employee = employees.FirstOrDefault(x => x.Id == id);

        return View(employee);
    }
    
    public ActionResult Add()
    {
        return View();
    } 

    [HttpPost]
    public ActionResult<string> Add(Person person)
    {
        return "Record saved";
    }
}
