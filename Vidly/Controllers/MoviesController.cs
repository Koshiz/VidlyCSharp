using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name ="John Smith"},
                new Customer { Name ="Mary Williams"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index()
        {
            var movies = GetMovie();
            return View(movies);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        private IEnumerable<Movie> GetMovie()
        {
            return new List<Movie>
            {
                new Movie() { Name ="Shrek"},
                new Movie() { Name ="Wall-e"}
            };
        }
    }
}