using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie{Id=1, Name="The Amazing Spiderman"},
                new Movie{Id=2, Name="The Amazing Spiderman 2"},
                new Movie{Id=3, Name="Spiderman Homecoming"}


            };
            
            var movie = new Movie {Movies = movies};
            return View(movie);

        }
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(0,12)}")]
        public ActionResult Released(int year, int month)
        {
           

            return Content(string.Format("Just testing! year={0}, month{1}", year, month));
        }

       
    }
}