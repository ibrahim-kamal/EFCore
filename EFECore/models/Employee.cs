﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFECore.models
{
    public class Employee
    {
        public int Id { get; set; } 

        public String firstname { get; set; }
        public String lastname { get; set; }
        public String Name { get; set; }
        [MaxLength(25)]
        [Comment("admin , Manager, agent")]
        public String Role { get; set; }
    }
}
