using MovieStoreData.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData
{
    public class MovieStoreDBContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCat> MovieCategories { get; set; }
        public DbSet<RentedMovie> RentedMovies { get; set; }
        public DbSet<Person> Persons { get; set; }

        
       
    }
}
