using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFECore.models
{
    public class Student
    {
        public int Id { get; set; }
        
        public string email{ get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string Token { get; set; }
        [Column("uuid")]
        public string UUID { get; set; }
        [NotMapped]
        public string mobile{ get; set; }
    }
}
