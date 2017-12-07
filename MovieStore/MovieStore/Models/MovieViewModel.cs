using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class MovieViewModel
    {
        [Key]
        public Guid MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string Director { get; set; }
        public string Category { get; set; }
        public int RentalDuration { get; set; }
        public int MovieRating { get; set; }
       
    }
}