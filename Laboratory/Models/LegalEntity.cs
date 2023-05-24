using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory.Models
{
    public class LegalEntity
    {
        [Key]
        public int ID { get; set; }
        public string? CompanyName { get; set; }
        public string? Address { get; set; }
        public int? TIN { get; set; }
        public int? PaymentAccount { get; set; }
        public int? BIC { get; set; }
        public string? Contact { get; set; }
        public string? PhoneNumber { get; set; }
        public int ClientID { get; set; }
        public Client? Client { get; set; }


    }
}
