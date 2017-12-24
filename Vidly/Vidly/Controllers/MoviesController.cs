using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }

        public ActionResult Edit(int? movieId)
        {
            if (!movieId.HasValue)
                movieId = 1;
            return Content("Id =" + movieId);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2})}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}