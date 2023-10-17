using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFECore.models
{
    public class User
    {
        public int Id { get; set; } 

        public String Name { get; set; }
        [Required]
        public String Password { get; set; }    
    }
}
