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
            optionsBuilder.UseSqlite("Date Scourse = aanwezigheidslijst.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Docent>()
                .ToTable("Docenten")
                .HasKey(d => d.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
