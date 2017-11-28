using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.DTO
{
    public class PictureDTO
    {
        [Key]
        public Guid id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
    }
}
