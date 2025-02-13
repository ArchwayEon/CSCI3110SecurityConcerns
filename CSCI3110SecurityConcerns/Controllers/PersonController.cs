using Microsoft.AspNetCore.Mvc;

namespace CSCI3110SecurityConcerns.Controllers;

public class PersonController : Controller
{
    public IActionResult Create()
    {
        return View();
    }
}
