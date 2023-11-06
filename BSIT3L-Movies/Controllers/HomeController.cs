using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
           new MovieViewModel { Id = 1, Name = "JOHN WICK", Rating = "13", Image = "movie1.jpg", Teaser = "https://youtu.be/C0BMx-qxsP4?si=H2KzoDByvwrH6vOR" },
           new MovieViewModel { Id = 2, Name = "THE CROODS", Rating = "6", Image = "movie2.jpg", Teaser = "https://youtu.be/EHGljhKT16I?si=NK6V7ILaOueeane-" },
           new MovieViewModel { Id = 3, Name = "SPIDER MAN 3", Rating = "12", Image = "es/movie3.jpg", Teaser = "https://www.youtube.com/watch?v=e5wUilOeOmg" },
           new MovieViewModel { Id = 4, Name = "HOW TO TRAIN YOUR DRAGON", Rating = "4", Image = "movie4.jpg", Teaser = "https://youtu.be/oKiYuIsPxYk?si=7rwzi3kWI3RdEKkz" },
           new MovieViewModel { Id = 5, Name = "THE EXPENDABLES 2", Rating = "13", Image = "movie5.jpg", Teaser = "https://youtu.be/ip_CYHdyUBs?si=JfGXXweFnV2fs9Zt" },
           new MovieViewModel { Id = 6, Name = "HACKSAW RIDGE", Rating = "13", Image = "/movies6.jpg", Teaser = "https://youtu.be/RdjO0p4GJPA?si=QFMXF1W9uvRWNCAF" },
           new MovieViewModel { Id = 7, Name = "AMERICAN SNIPER", Rating = "18", Image = "movie7.jpg", Teaser = "\"https://youtu.be/99k3u9ay1gs?si=av7AoYxjCnEj6Ec_" },
           new MovieViewModel { Id = 8, Name = " lONE SURVIVOR", Rating = "13", Image = "movie8.jpg", Teaser = "https://youtu.be/yoLFk4JK_RM?si=pEaeujTLKOrqIqlT" },
           new MovieViewModel { Id = 9, Name = "ENOLA HOLMES", Rating = "6", Image = "movie9jpeg", Teaser = "https://youtu.be/1d0Zf9sXlHk?si=VTNHJgnYSObIAYnd" },
           new MovieViewModel { Id = 10, Name = "EXTRACTION 2", Rating = "13", Image = "movie10.jpg", Teaser = "https://www.youtube.com/watch?v=YJXqvnT_rsk" },
           new MovieViewModel { Id = 11, Name = "SHERLOCK HOLMES", Rating = "6", Image = "movie11.jpg", Teaser = "https://youtu.be/iKUzhzustok?si=E4qxMjYxKXMz3C1a" },
           new MovieViewModel { Id = 12, Name = "THE INCREDIBLES", Rating = "13", Image = "movie12.jpg", Teaser = "https://youtu.be/-UaGUdNJdRQ?si=p9Pst9TGWDWmm66u" },
           new MovieViewModel { Id = 13, Name = "FRIDAY THE 13TH", Rating = "18", Image = "movie13.jpg", Teaser = "https://youtu.be/cCfO1aB8CIE?si=lrHRn0fEsV0Ci4Bc" },
           new MovieViewModel { Id = 14, Name = "ALIVE", Rating = "13", Image = "movie14.jpg", Teaser = "https://youtu.be/jQ8CCg1tOqc?si=b1wUQdyq2XgfGYb2" },
           new MovieViewModel { Id = 15, Name = "AVENGERS ENDGAME", Rating = "12", Image = "movie15.jpeg", Teaser = "https://youtu.be/TcMBFSGVi1c?si=xffYoe-CYiUDvcpj" },
           
           

        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

