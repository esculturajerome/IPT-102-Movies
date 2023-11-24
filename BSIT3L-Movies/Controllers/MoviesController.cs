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
               new MovieViewModel { Id = 1, Name = "JOHN WICK", Rating = "13", Image = "movie1.jpg", Teaser = "Legendary assassin John Wick retired from his violent career after marrying the love of his life. Her sudden death leaves John in deep mourning" },
            new MovieViewModel { Id = 2, Name = "THE CROODS", Rating = "6", Image = "movie2.jpg", Teaser = "THE CROODS-Prehistoric family the Croods live in a particularly dangerous moment in time. Patriarch Grug, his mate, Ugga , teenage daughter,son Thunk and feisty Gran gather food by day and huddle together in a cave at night. When a more evolved caveman named Guy  arrives on the scene, Grug is distrustful, but it soon becomes apparent that Guy is correct about the impending destruction of their world" },
            new MovieViewModel { Id = 3, Name = "SPIDERMAN 3", Rating = "5", Image ="movie3.jpg", Teaser = "Peter Parker  and M.J. seem to finally be on the right track in their complicated relationship, but trouble looms for the superhero and his lover. Peter's Spider-Man suit turns black and takes control of him, not only giving Peter enhanced power but also bringing out the dark side of his personality. Peter must overcome the suit's influence as two supervillains, Sandman and Venom, rise up to destroy him and all those he holds dear" },
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
