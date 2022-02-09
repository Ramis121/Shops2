using Microsoft.EntityFrameworkCore;
using Shops2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shops2.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Phone> phone { get; set; }
        public DbSet<Order> companie { get; set; }
    }
}
