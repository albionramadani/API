using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            :base (options)
        {

        }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
