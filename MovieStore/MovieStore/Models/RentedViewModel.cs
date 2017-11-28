using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class RentedViewModel
    {
        [Key]
        public Guid RentalId { get; set; }

        public Guid MovieId { get; set; }
        public Guid PesonId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        
        public MovieViewModel Movie { get; set; }
        public PersonViewModel Person { get; set; }

    }
}