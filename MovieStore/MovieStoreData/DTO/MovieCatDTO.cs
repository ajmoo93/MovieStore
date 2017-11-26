using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.DTO
{
    public class MovieCatDTO
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<MovieDTO> Movies { get; set; }
    }
}
