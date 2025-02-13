using CSCI3110SecurityConcerns.Models;
using CSCI3110SecurityConcerns.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CSCI3110SecurityConcerns.Controllers;

public class PersonController : Controller
{
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Person person)
    {
        return Json(person);
    }

    public IActionResult CreateWithBind()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult CreateWithBind(
        [Bind("FirstName,LastName,DateOfBirth")]Person person)
    {
        return Json(person);
    }

    public IActionResult CreateWithVM()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult CreateWithVM(CreatePersonVM personVM)
    {
        return Json(personVM.GetPersonInstance());
    }

}
