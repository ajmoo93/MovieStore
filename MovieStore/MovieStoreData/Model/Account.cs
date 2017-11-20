using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.Model
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Email { get; set; }
        public string Psw { get; set; }
        /*Account have many person */
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person person { get; set; }
    }
}
