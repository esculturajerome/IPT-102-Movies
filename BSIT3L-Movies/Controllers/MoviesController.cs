 using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BSIT3L_Movies.Models
{
    public class MoviesController : Controller
    {
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        public class Modelscontroller : Controller
        {
           
            }

            public IActionResult GetMovies()
            {
                MovieViewModel movie = new MovieViewModel
                {
                    Id = 1,
                    Name = "JOHN WICK",
                    Image = "movie.1.jpg",
                    Teaser = "\r\nAn ex-hitman comes out of retirement to track down the gangsters that took everything from him. With New York City as his bullet-riddled playground, JOHN WICK (Keanu Reeves) is a fresh and stylized take on the \"assassin genre\". ",


                };

                return View(movie);
            }

            private string GetDebuggerDisplay()
            {
                return ToString();
            }
        }

    }

