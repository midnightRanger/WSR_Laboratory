using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory.Models
{
    public class OrderService
    {
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int ServiceID { get; set; }
        public Service Service { get; set; }
    }
}
