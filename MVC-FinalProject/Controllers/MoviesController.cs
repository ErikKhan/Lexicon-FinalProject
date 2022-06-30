using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_FinalProject.Data;
using MVC_FinalProject.Models;


namespace MVC_FinalProject.Controllers
{
    public class MoviesController : Controller
    {
        ApplicationDbContext Context;
        public MoviesController(ApplicationDbContext context)
        {
            Context = context;
        }
        [Authorize]
        public IActionResult Index(string search)
        {
            ViewData["CurrentFilter"] = search;
            List<Movie> AllMovies = Context.Movies.ToList();
            List<Movie> moviesTemp = new List<Movie>();

            if (!string.IsNullOrEmpty(search))
            {
                moviesTemp = AllMovies.Where(b => b.Name.ToLower().Contains(search)).ToList();
            }
            if (moviesTemp.Count > 0) { return View(moviesTemp); }
            else return View(AllMovies);
        }
        [HttpGet]
/*        public IActionResult Index(string search)
        {
            var movies = from b in Context.Movies select b;
            
            return View(moviesTemp);
        }*/
        public IActionResult GetMovie()
        {
            List<Movie> AllMovies = Context.Movies.ToList();
            return View(AllMovies);
        }
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id, string name, string description, string imageurl)
        {
            Movie Movie = new Movie();
            
            Movie.Name = name;
            Movie.Description = description;
            Movie.ImageUrl = imageurl;
            Context.Movies.Add(Movie);
            Context.SaveChanges();
            System.Diagnostics.Debug.WriteLine($"ID: {Movie.Id} Name: {Movie.Name} Price: {Movie.Description} imageURl: {Movie.ImageUrl}");
            return RedirectToAction("Index", Movie);
        }
        [Authorize]
        public IActionResult Edit(int id)
        {
            var x = Context.Movies.FirstOrDefault(x => x.Id == id);
            return View(x);
        }
        [HttpPost]
        public IActionResult Edit(int id, string name, string description, string imageurl)
        {
            var Movie = Context.Movies.FirstOrDefault(x => x.Id == id);
            Movie.Name = name;
            Movie.Description = description;
            Movie.ImageUrl = imageurl;
            Context.SaveChanges();
            return RedirectToAction("index");
        }
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            Movie Movie = Context.Movies.FirstOrDefault(x => x.Id == id);
            return View(Movie);
        }
        [HttpPost]
        public IActionResult DeleteMovie(int id)
        {
            Movie Movie = Context.Movies.FirstOrDefault(x => x.Id == id);
            Context.Remove(Movie);
            Context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Details(int? id)
        {
            Movie Movie = Context.Movies.FirstOrDefault(x => x.Id == id);
            return View(Movie);
        }
    }
}
