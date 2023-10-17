﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFECore.models
{
    [Table("Photos")]
    public class Image
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Post post { get; set; }
    }
}
