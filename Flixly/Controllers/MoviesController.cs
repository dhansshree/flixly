using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Flixly.Models;

namespace Flixly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Dhans" };
            return View(movie);

            //return Content("asdasd");

            //return new EmptyResult();

            //return new HttpNotFoundResult();

        }

        public ActionResult Index()
        {
            var movies = new List<Movie>()
            {
                new Movie(){ Id=1,Name ="Sixth Sense"},
                new Movie(){ Id=1,Name ="Finding Nemo"}
            };

            return View(movies);
        }
    }
}