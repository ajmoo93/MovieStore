using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class RentedViewModel
    {
        public Guid RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}