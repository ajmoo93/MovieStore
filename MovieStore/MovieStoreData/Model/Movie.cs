using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.Model
{
    public class Movie
    {
        public Guid MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string Director { get; set; }
        public int RentalDuration { get; set; }
        public int MovieRating { get; set; }


        public MovieCat MovieCat { get; set; }
    }
}
