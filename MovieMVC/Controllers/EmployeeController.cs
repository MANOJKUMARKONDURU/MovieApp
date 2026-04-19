using Microsoft.AspNetCore.Mvc;
using MovieMVC.Models;

namespace MovieMVC.Controllers;

public class EmployeeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Employee employee)
    {
        if (ModelState.IsValid)
        {
            //save the data
            return RedirectToAction("Index");
        }
        return View(employee);
    }
}