using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.DTO
{
    public class MovieDTO
    {
        [Key]
        public Guid MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string Director { get; set; }
        public int RentalDuration { get; set; }
        public int MovieRating { get; set; }
        public Guid MovieCatId { get; set; }

        public virtual MovieCatDTO MovieCat { get; set; }

        public virtual ICollection<PictureDTO> Pictures { get; set; }
        public virtual ICollection<CommentDTO> Comments { get; set; }
    }
}
