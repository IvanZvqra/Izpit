using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class IvanTopalskiDBContext: DbContext

    {
        public IvanTopalskiDBContext() { }
        public IvanTopalskiDBContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-T5IEDBL;Database=IvanTopalski_11e;Trusted_Connection=True;");

        }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
