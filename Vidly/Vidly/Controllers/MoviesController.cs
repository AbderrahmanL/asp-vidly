using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};

            List<Customer> customers = new List<Customer>()
            {
                new Customer() {Name = "Ahmed"},
                new Customer() {Name = "Muhammed"}
            };

            RandomViewModel randomVm = new RandomViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(randomVm);
        }

        public ActionResult Edit(int? movieId)
        {
            if (!movieId.HasValue)
                movieId = 1;
            return Content("Id =" + movieId);
        }

        [Route("Movies/Released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("movies")]
        public ActionResult Movies()
        {
            var movie1 = new Movie() {Name = "Shrek!"};
            var movie2 = new Movie() {Name = "Sherlock Holms!"};
            var movies = new List<Movie>()
            {
                movie1,
                movie2
            };
            var moviesVM = new MoviesViewModel()
            {
                Movies = movies
            };
            return View(moviesVM);
        }
    }
}