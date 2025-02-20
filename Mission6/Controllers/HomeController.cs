using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6.Models;

namespace Mission6.Controllers
{   
    //make routes to the pages
    public class HomeController : Controller
    {
       private Class1 _class1;
        public HomeController(Class1 db) 
        { 
            _class1 = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult GTKJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DataEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DataEntry(Form res)
        {
            _class1.Movies.Add(res);
            _class1.SaveChanges();



            return View("Confirmation");
        }

        public IActionResult Table()
        {
            var data = _class1.Movies
                .FromSqlRaw("SELECT * FROM MOVIES").ToList();

            return View(data);
        }
        


    }
}
