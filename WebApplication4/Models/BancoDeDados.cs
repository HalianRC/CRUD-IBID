using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Clients> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"server=(localdb)\mssqllocaldb;Database=WebApplication4;Integrated Security=True");
        }

    }
}
