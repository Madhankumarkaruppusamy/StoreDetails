using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Store.Models
{
    public class DatabaseContext:DbContext
    {
         
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Order> Orders { get; set; }
    }

}
