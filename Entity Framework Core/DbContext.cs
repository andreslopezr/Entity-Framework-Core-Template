using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Entity_Framework_Core_Template
{
    public class NameContext : DbContext
    {
        public DbSet<class1> class1 { get; set; }
        public DbSet<class2> class2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL ("server=localhost; database=name; user=Admin; password=Admin");
        }
    }
}