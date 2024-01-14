using Lesson2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson2
{
    public class ETicaretDbContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Parca> Parcalar { get; set; }
        public DbSet<UrunParca> UrunParcalar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Prodiver
            //Connection String
            //Lazy Loading vb. ayarlar yapılır. 

            optionsBuilder.UseNpgsql("Host=localhost;Port=5455;Database=ECommerce;Username=postgres;Password=postgres");



            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UrunParca>()
                .HasKey(x => new
                {
                    x.ParcaId,
                    x.UrunId
                });
        }
    }

}
