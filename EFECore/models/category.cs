using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFECore.models
{
    [Table("Categories" , Schema ="ecommercy")]
    public class category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
