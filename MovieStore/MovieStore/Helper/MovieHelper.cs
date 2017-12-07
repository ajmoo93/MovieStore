using MovieStore.Models;
using MovieStoreData.DTO;
using MovieStoreData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Helper
{
    public class MovieHelper
    {
        //public static ICollection<MovieViewModel> MovieHelperMapper(ICollection<Movie> movies)
        //{
        //    var result = new List<MovieViewModel>();
        //    movies.ToList().ForEach(x => result.Add(MovieHelperMapper(x)));
        //    return result;
        //}
        
        //public static ICollection<Movie> MovieHelperModel(ICollection<MovieViewModel> movies)
        //{
        //    var result = new List<Movie>();
        //    movies.ToList().ForEach(x => result.Add(MovieHelperModel(x)));
        //    return result;
        //}
       
       
        public static MovieViewModel EntityToModel(Movie movie)
        {
            var movieModel = new MovieViewModel
            {
                MovieId = movie.MovieId,
                MovieTitle = movie.MovieTitle,
                Category = movie.Category,
                Director = movie.Director,
                RentalDuration = movie.RentalDuration,
                MovieRating = movie.MovieRating,
            };
            return movieModel;

        }
        public static Movie ModelToEntity(MovieViewModel movie)
        {
            var movieHelper = new Movie
            {
                MovieId = movie.MovieId,
                MovieTitle = movie.MovieTitle,
                Category = movie.Category,
                Director = movie.Director,
                MovieRating = movie.MovieRating,
                RentalDuration = movie.RentalDuration,
            };
            return movieHelper;

        }
    }
}