using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.Model
{
    public class RentedMovie
    {
        public Guid RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        [ForeignKey("Movie")]
        public Guid MovieId { get; set; }
        [ForeignKey("Person")]
        public Guid PersonId { get; set; }

        public Person Person { get; set; }
        public Movie Movies { get; set; }
    }
}
