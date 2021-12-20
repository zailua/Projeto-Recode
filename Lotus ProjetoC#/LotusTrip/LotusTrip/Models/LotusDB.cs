using Microsoft.EntityFrameworkCore;

namespace LotusTrip.Models
{
    public class LotusDB : DbContext
    {
        public DbSet<Destino> Destinos { get; set; }

        public DbSet<Promocao> Promocoes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=LotusTrip;Integrated Security=True");
        }

    }
}
