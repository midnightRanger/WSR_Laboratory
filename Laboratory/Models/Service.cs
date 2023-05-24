using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int? ExecutionPeriod { get; set; }
        public float? AverageDeviation { get; set; }
        public float? Cost { get; set; }
        public float? CostCJSC { get; set; }
        public List<EmployeeService> EmployeeService { get; set; } = new();
        public List<OrderService> OrderServices { get; set; } = new();
    }
}
