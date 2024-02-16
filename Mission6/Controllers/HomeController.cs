using Microsoft.AspNetCore.Mvc;
using Mission6.Models;
using SQLitePCL;
using System.Diagnostics;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;
        public HomeController(MovieContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Survey()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Survey(Movie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Confirm");
        }

    }
}
