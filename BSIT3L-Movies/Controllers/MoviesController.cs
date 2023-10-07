using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<Movie> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Titanic", Rating = "5" },
                new Movie { Id = 2, Name = "Inception", Rating = "4" },
                new Movie { Id = 3, Name = "The Shawshank Redemption", Rating = "5" }
            };
        }
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
    }
}

