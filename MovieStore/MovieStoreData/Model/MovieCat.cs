using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.Model
{
    public class MovieCat
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
        public virtual Movie Movie { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

    }
}
