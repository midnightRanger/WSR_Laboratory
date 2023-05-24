using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public string? OrderNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public string ClientID { get; set; }
        public Client Client { get; set; }
        public string? Status { get; set; }
        public DateTime? EndDate { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int? ExecutionTime { get; set; }

        public List<OrderService> OrderServices { get; set; } = new();

    }
}
