using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFECore.models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string title { get; set; }
        [Column(TypeName ="varchar(255)")]
        public String slug { get; set; }
        public String Content { get; set; }


    }
}
