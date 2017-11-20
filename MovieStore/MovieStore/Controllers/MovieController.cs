using MovieStore.Helper;
using MovieStore.Models;
using MovieStoreData.Interface;
using MovieStoreData.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStore.Controllers
{
    public class MovieController : Controller
    {
        private readonly IRepository repo;

        public MovieController()
        {
            repo = new Repository();
        }
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MovieCreate()
        {
            return PartialView(new MovieViewModel());
        }
        [HttpPost]
        public ActionResult MovieCreate(MovieViewModel movies)
        {
            //om movieState är valid
            if (ModelState.IsValid)
            {
                //mappar vi movies för att få dem
                repo.CreateMovie(MovieHelper.MovieHelperModel(movies));
                //sen skickas vi till home och visar filmerna
                return PartialView("Home", MovieHelper.MovieHelperMapper(repo.GetMovie()));
            }
            return PartialView("CreateMovie", movies);
            //movies.MovieId = Guid.NewGuid();
            //movies.MovieTitle = movies.MovieTitle;
            //movies.Director = movies.Director;
            //movies.RentalDuration = movies.RentalDuration;
            //movies.MovieRating = movies.MovieRating;
            //var movie = MovieHelper.MovieHelperModel(movies);
            //repo.CreateMovie(movie);
            //return View(movies);
        }
        public ActionResult EditMovie(Guid Id)
        {
            return PartialView();
        }
        public ActionResult EditMovie(MovieViewModel movie)
        {
            //först så mappar vi om movie
            repo.EditMovie(MovieHelper.MovieHelperModel(movie));
            //skickar till Home och visar filmerna.
            return PartialView("Home", MovieHelper.MovieHelperMapper(repo.GetMovie()));
        }
        public ActionResult DeleteMovie()
        {
            return View();
        }
    }
}