using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class CommentVeiwModel
    {
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        public int PersonId { get; set; }
        public int MovieId { get; set; }

        [Display(Name ="Posted")]
        public DateTime DatePosted { get; set; }
        [Display(Name = "Edited")]

        public DateTime DateEdited { get; set; }

        public MovieViewModel Movie { get; set; }
        public PersonViewModel Person { get; set; }
    }
}