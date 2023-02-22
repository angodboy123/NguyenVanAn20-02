using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using NguyenVanAn1921050025.Models;

namespace NguyenVanAn1921050025.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Employee()
        {
            return View();
        }
    }
}