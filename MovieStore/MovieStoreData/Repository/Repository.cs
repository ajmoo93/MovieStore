using MovieStoreData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreData.DTO;
using MovieStoreData.Model;

namespace MovieStoreData.Repository
{
    public class Repository : IRepository
    {
        public void CreateAccount(AccountDTO dto)
        {
            throw new NotImplementedException();
        }

        public void CreateMovie(Movie dto)
        {
            using (var context = new MovieStoreDBContext())
            {
                var newMovie = new Movie
                {

                    MovieId = Guid.NewGuid(),
                    MovieTitle = dto.MovieTitle,
                    Category = dto.Category,
                    MovieRating = dto.MovieRating,
                    Director = dto.Director,
                    RentalDuration = dto.RentalDuration,
                };

                context.Movies.Add(newMovie);
                context.SaveChanges();
            }
        }

        public void CreatePerson(PersonDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(AccountDTO accountId)
        {
            using (var context = new MovieStoreDBContext())
            {
                var AccountDelete = context.Accounts.Find(accountId);
                if (AccountDelete != null) context.Accounts.Remove(AccountDelete);

                //var AccountD = context.Accounts.FirstOrDefault(x => x.AccountID == accountId.AccountID);
                //context.Accounts.Remove(AccountD);

                context.SaveChanges();
            }
        }

        public void DeleteAccount(Guid accountId)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(MovieDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(Guid movieId)
        {
            using (var context = new MovieStoreDBContext())
            {
                //ska du göra where så får du ha firstOrDefault i slutet av lambdan
                //kalla på context movies och Lambda metod som kolla movieId
                var moviesToDelete = context.Movies.Find(movieId);
                //context movie removie movieToDelete
                context.Movies.Remove(moviesToDelete);
                context.SaveChanges();

            }
        }

        public void EditAccount(AccountDTO dto)
        {
            throw new NotImplementedException();
        }

        public void EditMovie(MovieDTO dto)
        {
            using (var context = new MovieStoreDBContext())
            {

                var MovieToEdit = context.Movies.Find(dto.MovieId);

                if (MovieToEdit != null)
                {
                    MovieToEdit.MovieTitle = dto.MovieTitle;
                    MovieToEdit.Director = dto.Director;
                    MovieToEdit.RentalDuration = dto.RentalDuration;
                    context.SaveChanges();

                }
            }

        }

        public void EditMovie(Movie dto)
        {
            throw new NotImplementedException();
        }


        //I enumerable är bra till om du bara ska iterera igenom listan( visa listan av objekt)
        //ICollection är för om du skall Iterera listan och modifiera objekt iden.
        //List<T> för om du skall iterera, modifiera och sortera.
        public IEnumerable<Movie> GetMovie()
        {
            using (var context = new MovieStoreDBContext())
            {
                var movie = context.Movies;
                return movie.ToList();

            }
        }


    }
}
