using Microsoft.EntityFrameworkCore;
using System;
using UWP_Aanwezigheidslijst.EF.Model;

namespace UWP_Aanwezigheidslijst.EF
{
    public class AanwezigheidslijstDBContext : DbContext
    {
        public DbSet<Docent> Docenten { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = aanwezigheidslijst.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Docent>()
                .Property(d => d.Naam).IsRequired();
            modelBuilder.Entity<Docent>()
                .ToTable("Docenten")
                .HasKey(d => d.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
