using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.DTO
{
    public class PersonDTO
    {
        public Guid PersonId { get; set; }

        public int PersonNumber { get; set; }

        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Adress { get; set; }

        public string Email { get; set; }

        public int MobileNumber { get; set; }

        public virtual ICollection<RentedDTO> MovieRents { get; set; }
        public virtual ICollection<MovieDTO> Movies { get; set; }
    }
}
