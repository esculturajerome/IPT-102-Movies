namespace BSIT3L_Movies.Controllers;

using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

public class MoviesController : Controller
{
    public MoviesController()
    {
    }

    public IActionResult Movies()
    {
        MovieViewModel movie = new MovieViewModel
        {
            Id = 1,
            Name = "JOHN WICK",
            Rating= "13",
            Image = "css/movie1.jpg",
            Teaser = "https://www.youtube.com/watch?v=C0BMx-qxsP4",
            Description = "An ex-hitman comes out of retirement to track down the gangsters that took everything from him. With New York City as his bullet-riddled playground, JOHN WICK (Keanu Reeves) is a fresh and stylized take on the 'assassin genre'."
        };

        return View(movie);
    }
}
