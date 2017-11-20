using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class MovieCatViewModel
    {
        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}