using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory.Models
{
    public class PhysicalEntity
    {
        [Key]
        public int Id { get; set; }
        public long? PassportSeries { get; set; }
        public long? PassportNumber { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string ClientID { get; set; }
        public Client Client { get; set; }
    }
}
