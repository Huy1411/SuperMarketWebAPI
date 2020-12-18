using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarketWebAPI.Models;

namespace SuperMarketWebAPI.Models
{
    public class SuperMarketDbContext:DbContext
    {
        public SuperMarketDbContext(DbContextOptions<SuperMarketDbContext> options): base(options)
        {

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProductOrders> ProductOrders{get; set;}
    }
}
