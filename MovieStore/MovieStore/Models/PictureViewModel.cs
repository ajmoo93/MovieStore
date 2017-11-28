using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class PictureViewModel
    {
        [Key]
        public Guid id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
    }
}