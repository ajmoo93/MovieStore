using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
   public enum CategoryName
    {
        Horror,
        Comedy,
        Thriller,
        Animated,
        Documentary,
        Action,
        Drama,
        Romantic,
        Scifi,

    }
    public class MovieCatViewModel
    {
        [Key]
        public Guid MovieCatId { get; set; }
        public CategoryName Name { get; set; }
    }
}