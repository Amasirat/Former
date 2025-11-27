using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Former.Models;

namespace Former.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}