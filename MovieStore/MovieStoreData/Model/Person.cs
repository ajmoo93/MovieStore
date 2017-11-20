using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.Model
{
    public class Person
    {
        [Key]
        public Guid PersonID { get; set; }
        public int PersonNumber { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public virtual Account Account { get; set; }
    }
}
