using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.Model
{
    public class Movie
    {
        [Key]
        public Guid MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string Director { get; set; }
        public string Category { get; set; }
        public int RentalDuration { get; set; }
        public int MovieRating { get; set; }
       


        
        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
