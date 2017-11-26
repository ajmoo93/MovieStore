using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.DTO
{
    public class CommentDTO
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int PersonId { get; set; }
        public int MovieId { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateEdited { get; set; }

        public virtual MovieDTO Movies { get; set; }
        public virtual PersonDTO Persons { get; set; }
    }
}
