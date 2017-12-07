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
    //Ändra Modellerna så att category finns i Movie istället eller ta bort enum
    //kolla varför movie har 3 movieCatID
    //
    public class MovieController : Controller
    {
        private readonly IRepository repo;

        public MovieController()
        {
            repo = new Repository();
        }
        // GET: Movie
        public ActionResult ShowMovies()
        {
           //lista av movieViewModel
            var movies = new List<MovieViewModel>();
            //kallar på alla movies
            var moviesFromDB = repo.GetMovie();
            //om movies finns så skicka ut dem
            if(moviesFromDB != null)
            {
                foreach(var movie in moviesFromDB)
                {
                    var movieToAdd = MovieHelper.EntityToModel(movie);
                    movies.Add(movieToAdd);
                    
                }
            }
            return View(movies);
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
                repo.CreateMovie(MovieHelper.ModelToEntity(movies));
                //sen skickas vi till home och visar filmerna
                return PartialView("ShowMovies");
            }
            return PartialView(movies);
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
        [HttpPost]
        public ActionResult EditMovie(MovieViewModel movie)
        {
            //först så mappar vi om movie
            repo.EditMovie(MovieHelper.ModelToEntity(movie));
            //skickar till Home och visar filmerna.
            return PartialView("ShowMovies");
        }
       
        [HttpDelete]
        public ActionResult DeleteMovie(Guid Id)
        {
            if(Id != null)
            {
                repo.DeleteMovie(Id);
            }
           
            
            return View("ShowMovie");
        }
    }
}