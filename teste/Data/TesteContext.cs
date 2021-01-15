using Microsoft.EntityFrameworkCore;
using teste.Models;

namespace teste.Data
{
    public class TesteContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public TesteContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}