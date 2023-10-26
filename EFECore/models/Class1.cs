using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFECore.models
{
    public class EmployeesPost
    {

        public int employeesPost { get; set; }
        public int EmployeeID { get; set; }
        public int PostId { get; set; }
    }
}
