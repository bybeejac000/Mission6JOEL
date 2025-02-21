using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
            ViewBag.cats = _class1.Cats
                .FromSqlRaw("SELECT * FROM Categories").ToList();

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
                .FromSqlRaw("SELECT * FROM Movies").ToList();
                 
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _class1.Movies
                .Where(m => m.MovieId == id)
                .ExecuteDelete();

            return RedirectToAction("Table");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Form data = _class1.Movies
                .Single(m => m.MovieId == id);

            ViewBag.cats = _class1.Cats
                .FromSqlRaw("SELECT * FROM Categories").ToList();

            return View("DataEntry",data);
        }

        [HttpPost]
        public IActionResult Edit(Form res)
        {
            _class1.Movies.Update(res);
            _class1.SaveChanges();



            return View("Confirmation");
        }




    }
}
