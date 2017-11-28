using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class PersonViewModel
    {
        [Key]
        public Guid PersonId { get; set; }
        [Required]
        public int PersonNumber { get; set; }
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int MobileNumber { get; set; }
        public Guid MovieId { get; set; }
        public Guid RentalId { get; set; } 
        public MovieViewModel Movie { get; set; }
        public RentedViewModel MovieRental { get; set; }
    }
}