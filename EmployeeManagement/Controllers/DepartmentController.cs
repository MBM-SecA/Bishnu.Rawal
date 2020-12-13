using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class DepartmentController : Controller
{
    private EMSContext db;

    public DepartmentController(EMSContext _db)
    {
        db = _db;
    }
    public ActionResult Index()
    {
        var department = db.Departments.ToList();
        return View(department);
    }

    public ActionResult Detail(int id)
    {
        var department = db.Departments.Find(id);
        return View(department);
    }

    [HttpGet]
    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Add(Department department)
    {
        db.Departments.Add(department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));

    }

    public ActionResult Edit(int id)
    {
        var department = db.Departments.Find(id);
        return View(department);
    }

    [HttpPost]
    public ActionResult Edit(Department department)
    {
        db.Departments.Attach(department);
        db.Departments.Update(department);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public ActionResult Delete(int id)
    {
        var department = db.Departments.Find(id);
        return View(department);
    }

    [HttpPost]
    public ActionResult Delete(Department department)
    {
        db.Departments.Attach(department);
        db.Departments.Remove(department);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}