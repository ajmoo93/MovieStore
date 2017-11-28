using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData.DTO
{
   public class AccountDTO
    {
        [Key]
        public Guid AccountId { get; set; }
        public string Email { get; set; }
        public string Psw { get; set; }
    }
}
