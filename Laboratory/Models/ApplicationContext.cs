using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 

namespace Laboratory.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Client { get; set; } 
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeService> EmployeeService { get; set; }
        public DbSet<LegalEntity> LegalEntity { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderService> OrderService { get; set; }
        public DbSet<PhysicalEntity> PhysicalEntity { get; set; }
        public DbSet<Service> Service { get; set; }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public ApplicationContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeService>().HasKey(es => new { es.IDService, es.IDEmployee });
            modelBuilder.Entity<OrderService>().HasKey(os => new { os.OrderID, os.ServiceID });


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=Laboratory; Trusted_Connection=true; Integrated Security=SSPI; TrustServerCertificate=True; ");
        }
    }
}
