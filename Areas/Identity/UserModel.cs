using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Areas.Identity
{
    public class UserModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@")]
        public int Name { get; set; }
        
    }
}
