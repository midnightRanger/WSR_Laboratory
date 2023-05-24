using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory.Models
{
    public class Employee
    {
        [Key]
        public int IDEmployee { get; set; }
        public string? Post { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Middlename { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? LastEntry { get; set; }
        public List<EmployeeService> EmployeeService { get; set; } = new();
        public List<Order> Orders { get; set; } = new(); 
    }
}
