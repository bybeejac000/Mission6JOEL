using System.Diagnostics;
using System.Runtime.CompilerServices;
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
            ViewBag.cats = _class1.Categories
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
          .Include(m => m.CatForm)  // Eagerly load the related Category data
          .ToList();

            return View(data);
        }

        //This Post method deletes a movie from db
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _class1.Movies
                .Where(m => m.MovieId == id)
                .ExecuteDelete();

            return RedirectToAction("Table");
        }

        //This get fills teh dataentry view with the right data
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Form data = _class1.Movies
                .Single(m => m.MovieId == id);

            ViewBag.cats = _class1.Categories
                .FromSqlRaw("SELECT * FROM Categories").ToList();

            return View("DataEntry",data);
        }

        //This Post tab graps teh data and edits it 
        [HttpPost]
        public IActionResult Edit(Form res)
        {
            _class1.Movies.Update(res);
            _class1.SaveChanges();



            return View("Confirmation");
        }




    }
}
