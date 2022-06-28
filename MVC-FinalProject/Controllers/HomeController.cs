using Microsoft.AspNetCore.Mvc;
using MVC_FinalProject.Data;
using MVC_FinalProject.Models;
using System.Diagnostics;

namespace MVC_FinalProject.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext Context;
        public HomeController(ApplicationDbContext context)
        {
            Context = context;
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            List<Movie> AllMovies = Context.Movies.ToList();
            return View(AllMovies);
        }

        public IActionResult Contact()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}