using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Likey.Models;
using Likey.Viewmodels;

namespace Likey.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var likes = _context.Likes;

            var users = new List<User>
            {
                new User { Name = "Al"},
                new User { Name = "Gill"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Users = users
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult List(int? pageIndex, string sortBy)
        {
            var movies = _context.Movies.ToList();

            return View(movies);

        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}