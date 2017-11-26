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

        public void CreateMovie(MovieDTO dto)
        {
            using (var context = new MovieStoreDBContext())
            {
                var newMovie = new MovieDTO
            {

                MovieId = Guid.NewGuid(),
                MovieTitle = dto.MovieTitle,
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
            using(var context = new MovieStoreDBContext())
            {
                var AccountDelete = context.Accounts.Find(accountId);
                    if (AccountDelete != null) context.Accounts.Remove(AccountDelete);

                //var AccountD = context.Accounts.FirstOrDefault(x => x.AccountID == accountId.AccountID);
                //context.Accounts.Remove(AccountD);

                context.SaveChanges();
            }
        }

        public void DeleteAccount(Guid AccountId)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(MovieDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(Guid MovieId)
        {
            throw new NotImplementedException();
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

                if(MovieToEdit != null)
                {
                    MovieToEdit.MovieTitle = dto.MovieTitle;
                    MovieToEdit.Director = dto.Director;
                    MovieToEdit.RentalDuration = dto.RentalDuration;
                    context.Entry(MovieToEdit).State = System.Data.Entity.EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public ICollection<Movie> GetMovie()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MovieDTO> GetMovie(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
