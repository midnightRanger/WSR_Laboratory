﻿using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory.Models
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        
        public string ID { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Middlename { get; set; }
        public int? Role { get; set; }
        public List<LegalEntity>? LegalEntities { get; set; }        
        public List<PhysicalEntity>? PhysicalEntities { get; set; }
        public List<Order> Orders { get; set; } = new();

    }
}
