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
            new MovieViewModel { Id = 1, Name = "JOHN WICK", Rating = "13", Image = "css/movie1.jpg", Teaser = "https://www.youtube.com/watch?v=C0BMx-qxsP4", Description = "An ex-hitman comes out of retirement to track down the gangsters that took everything from him. With New York City as his bullet-riddled playground, JOHN WICK (Keanu Reeves) is a fresh and stylized take on the 'assassin genre'." },
            new MovieViewModel { Id = 2, Name = "THE CROODS",Rating = "6", Image = "css/movie2.jpg", Teaser = "https://youtu.be/EHGljhKT16I?si=NK6V7ILaOueeane-", Description ="Prehistoric family the Croods live in a particularly dangerous moment in time. Patriarch Grug, his mate, Ugga, teenage daughter, son Thunk, and feisty Gran gather food by day and huddle together in a cave at night.\"." },
            new MovieViewModel { Id = 3, Name = "SPIDER MAN 3", Rating = "12", Image = "css/movie3.jpg", Teaser = "https://www.youtube.com/watch?v=e5wUilOeOmg",Description ="Peter Parker  and M.J. seem to finally be on the right track in their complicated relationship, but trouble looms for the superhero and his lover. Peter's Spider-Man suit turns black and takes control of him, not only giving Peter enhanced power but also bringing out the dark side of his personality. Peter must overcome the suit's influence as two supervillains, Sandman and Venom, rise up to destroy him and all those he holds dear" },
            new MovieViewModel { Id = 4, Name = "HOW TO TRAIN YOUR DRAGON", Rating = "12-", Image = "css/movie4.jpg", Teaser = "https://youtu.be/oKiYuIsPxYk?si=7rwzi3kWI3RdEKkz",Description = "Hiccup is a Norse teenager from the island of Berk, where fighting dragons is a way of life. His progressive views and weird sense of humor make him a misfit, despite the fact that his father is chief of the clan. Tossed into dragon-fighting school, he endeavors to prove himself as a true Viking, but when he befriends an injured dragon he names Toothless, he has the chance to plot a new course for his people's future" },
            new MovieViewModel { Id = 5, Name = "THE EXPENDABLES 2", Rating = "13", Image = "css/movie5.jpg", Teaser = "https://youtu.be/ip_CYHdyUBs?si=JfGXXweFnV2fs9Zt",Description = "Mercenary leader Barney Ross, Lee Christmas and the rest of the Expendables team reunite when Mr. Church hires them for a seemingly easy job. But things go terribly wrong, compelling the mercenaries to seek revenge for a comrade's murder. With the odds against them, Barney and his team are hell-bent on payback and cut a path of destruction through opposing forces, only to encounter an unexpected threat: six pounds of weapons-grade plutonium."},
            new MovieViewModel { Id = 6, Name = "HACKSAW RIDGE", Rating = " 13-", Image = "css/movie6.jpg", Teaser = "https://youtu.be/RdjO0p4GJPA?si=QFMXF1W9uvRWNCAF",Description ="The true story of Pfc. Desmond T. Doss, who won the Congressional Medal of Honor despite refusing to bear arms during WWII on religious grounds. Doss was drafted and ostracized by fellow soldiers for his pacifist stance but went on to earn respect and adoration for his bravery, selflessness and compassion after he risked his life -- without firing a shot -- to save 75 men in the Battle of Okinawa." },
            new MovieViewModel { Id = 7, Name = "AMERICAN SNIPER", Rating = "13.", Image = "css/movie7.jpg", Teaser = "\"https://youtu.be/99k3u9ay1gs?si=av7AoYxjCnEj6Ec",Description ="U.S. Navy SEAL Chris Kyle takes his sole mission -- protect his comrades -- to heart and becomes one of the most lethal snipers in American history. His pinpoint accuracy not only saves countless lives but also makes him a prime target of insurgents. Despite grave danger and his struggle to be a good husband and father to his family back in the States, Kyle serves four tours of duty in Iraq. However, when he finally returns home, he finds that he cannot leave the war behind." },
           new MovieViewModel { Id = 8, Name = " lONE SURVIVOR", Rating = "13.", Image = "css/movie8.jpg", Teaser = "https://youtu.be/yoLFk4JK_RM?si=pEaeujTLKOrqIqlT",Description ="In 2005 Afghanistan, Navy SEALs Marcus Luttrell, Michael Murphy , Danny Dietz and Matthew \"Axe\" Axelson deploy on a mission of surveillance and to take out Taliban leader Ahmad Shah. Though spotted by goatherds, Luttrell and his team decide not to kill them. But one of the Afghans alerts a group of Taliban fighters to the invaders, and a terrible battle ensues, in which the SEALs find themselves hopelessly outnumbered and outgunned." },
           new MovieViewModel { Id = 9, Name = "ENOLA HOLMES", Rating = "6", Image = "css/movie9.jpg",Teaser = "https://youtu.be/1d0Zf9sXlHk?si=VTNHJgnYSObIAYnd",Description ="While searching for her missing mother, intrepid teen Enola Holmes uses her sleuthing skills to outsmart big brother Sherlock and help a runaway lord." },
           new MovieViewModel { Id = 10, Name = "EXTRACTION 2", Rating = "13", Image = "css/movie10.jpg", Teaser = "https://www.youtube.com/watch?v=YJXqvnT_rsk",Description ="Back from the brink of death, commando Tyler Rake embarks on a dangerous mission to save a ruthless gangster's imprisoned family." },
           new MovieViewModel { Id = 11, Name = "SHERLOCK HOLMES", Rating = "6", Image = "css/movie11.jpg", Teaser = "https://youtu.be/iKUzhzustok?si=E4qxMjYxKXMz3C1a",Description ="Sherlock Holmes is a private detective who has keen powers of observation. He lives at 221b Baker Street in London. He notices things that others simply don't and then he draws accurate conclusions about what he sees. He experiences strong mood swings, plays the violin, and is a master of deductive reasoning." },
           new MovieViewModel { Id = 12, Name = "THE INCREDIBLES", Rating = "13", Image = "css/movie12.jpg", Teaser = "https://youtu.be/-UaGUdNJdRQ?si=p9Pst9TGWDWmm66u",Description ="In this lauded Pixar animated film, married superheroes Mr. Incredible  and Elastigirl  are forced to assume mundane lives as Bob and Helen Parr after all super-powered activities have been banned by the government. While Mr. Incredible loves his wife and kids, he longs to return to a life of adventure, and he gets a chance when summoned to an island to battle an out-of-control robot. Soon, Mr. Incredible is in trouble, and it's up to his family to save him." },
           new MovieViewModel { Id = 13, Name = "FRIDAY THE 13TH", Rating = "18", Image = "css/movie13.jpg", Teaser = "https://youtu.be/cCfO1aB8CIE?si=lrHRn0fEsV0Ci4Bc",Description ="Crystal Lake's history of murder doesn't deter counselors from setting up a summer camp in the woodsy area. Superstitious locals warn against it, but the fresh-faced young people -- Jack, Alice, Bill ,Marcie and Ned - pay little heed to the old-timers. Then they find themselves stalked by a brutal killer. As they're slashed, shot and stabbed, the counselors struggle to stay alive against a merciless opponent." },
           new MovieViewModel { Id = 14, Name = "ALIVE", Rating = "13", Image = "css/movie14.jpg", Teaser = "https://youtu.be/jQ8CCg1tOqc?si=b1wUQdyq2XgfGYb2",Description ="While a grisly virus ravages a Korean city, Joon-woo tries to stay safe by locking himself inside his apartment. Just as he loses hope, he discovers another survivor." },
           new MovieViewModel { Id = 15, Name = "AVENGERS ENDGAME", Rating = "12", Image = "css/movie15.jpeg", Teaser = "https://youtu.be/TcMBFSGVi1c?si=xffYoe-CYiUDvcpj",Description ="Adrift in space with no food or water, Tony Stark sends a message to Pepper Potts as his oxygen supply starts to dwindle. Meanwhile, the remaining Avengers -- Thor, Black Widow, Captain America and Bruce Banner -- must figure out a way to bring back their vanquished allies for an epic showdown with Thanos -- the evil demigod who decimated the planet and the universe." },
           
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
