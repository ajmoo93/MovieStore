using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.Model
{
    public class MovieCat
    {
        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; }
        [ForeignKey("Movie")]
        public Guid MovieId { get; set; }
        public Movie Movies { get; set; }
    }
}
