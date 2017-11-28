using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class MovieCatViewModel
    {
        [Key]
        public Guid MovieCatId { get; set; }
        public string CategoryName { get; set; }
    }
}