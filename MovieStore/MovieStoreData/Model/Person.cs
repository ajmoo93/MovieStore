﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.Model
{
    public class Person
    {
        [Key]
        public Guid PersonId { get; set; }
        public int PersonNumber { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public Guid MovieId { get; set; }

        public ICollection<Movie> Movies { get; set; }
        public ICollection<RentedMovie> MovieRents { get; set; }
    }
}
