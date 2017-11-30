using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.DTO
{
    public class MovieCatDTO
    {
        public enum CategoryName
        {
            Horror,
            Commedy,
            Thriller,
            Animated,
            Documentary,
            Action,
            Drama,
            Romantic,
            Scifi,

        }
        [Key]
        public Guid MovieCatId { get; set; }
        public CategoryName Name { get; set; }

        public Guid MovieId { get; set; }
        public virtual ICollection<MovieDTO> Movies { get; set; }
    }
}
