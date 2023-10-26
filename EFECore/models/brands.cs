using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFECore.models
{
    public class brands
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte id { get; set; }

        public string name { get; set; }
    }
}
