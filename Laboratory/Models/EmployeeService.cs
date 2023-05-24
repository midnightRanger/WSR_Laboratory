using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory.Models
{
    public class EmployeeService
    {
        public int IDEmployee { get; set; }
        public Employee Employee { get; set; }
        public int IDService { get; set; }
        public Service Service { get; set; }

    }
}
