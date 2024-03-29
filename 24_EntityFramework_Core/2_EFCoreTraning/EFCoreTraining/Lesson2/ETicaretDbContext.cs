﻿using Lesson2.Models;
using Lesson2.Models.Base;
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
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added && (entry is BaseEntity ==true))
                {
                    entry.Property("CreatedTime").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }

}
