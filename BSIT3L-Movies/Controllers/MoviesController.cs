using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
    public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
        {
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
               new MovieViewModel { Id = 1, Name = "John Wick", Rating = "13", Image = "movie1.jpg", Teaser = "Legendary assassin John Wick retired from his violent career after marrying the love of his life. Her sudden death leaves John in deep mourning" },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "6", Image = "movie2.jpg", Teaser = "Science Fiction/Thriller" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", Image ="movie3.jpg", Teaser = "Drama" },
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "13" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}
