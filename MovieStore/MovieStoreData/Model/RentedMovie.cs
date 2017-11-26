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
        
        public Guid MovieId { get; set; }
        
        public Guid PersonId { get; set; }

        public virtual Person Person { get; set; }
        public virtual Movie Movies { get; set; }
    }
}
