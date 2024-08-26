using Microsoft.EntityFrameworkCore;
using Condidat.Domain.Entities;

namespace Condidat.Infrastructure.Context
{
    public class CondidatDbContext : DbContext
    {
        public CondidatDbContext(DbContextOptions<CondidatDbContext> options) : base(options)
        {
        }

        public DbSet<Condidate> Condidats { get; set; } = null!;
        public DbSet<Region> Regions { get; set; } = null!;
        public DbSet<Ville> Villes { get; set; } = null!;
        public DbSet<Commune> Communes { get; set; } =null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Region>().HasData(
                new Region { RegionId = "1", Name = "Rabat,Sale,Kenitra" },
                new Region { RegionId = "2", Name = "Casablanca,Settat" },
                new Region { RegionId = "3", Name = "Marrakech-Safi" },
                new Region { RegionId = "4", Name = "Fes,Meknes" },
                new Region { RegionId = "5", Name = "Tnger,Tetouin,Al houcaima" }
            );



            modelBuilder.Entity<Ville>().HasData(
                new Ville { VilleId = "1", Name = "Rabat", RegionId = "1" },
                new Ville { VilleId = "2", Name = "Sale", RegionId = "1" },
                new Ville { VilleId = "3", Name = "kenitra", RegionId = "1" },
                new Ville { VilleId = "4", Name = "Casablanca", RegionId = "2" },
                new Ville { VilleId = "5", Name = "Settat", RegionId = "2" },
                new Ville { VilleId = "6", Name = "Marrakech", RegionId = "3" },
                new Ville { VilleId = "7", Name = "Safi", RegionId = "3" },
                new Ville { VilleId = "8", Name = "Fes", RegionId = "4" },
                new Ville { VilleId = "9", Name = "Meknes", RegionId = "4" },
                new Ville { VilleId = "10", Name = "Tanger", RegionId = "5" },
                new Ville { VilleId = "11", Name = "Tetouin", RegionId = "5" },
                new Ville { VilleId = "12", Name = "Al houcaima", RegionId = "5" }
            );



            modelBuilder.Entity<Commune>().HasData(
                new Commune { CommuneId = "1", Name = "Assilah", VilleId = "10" },
                new Commune { CommuneId = "2", Name = "M'diq-Fnideq", VilleId = "10" },
                new Commune { CommuneId = "3", Name = "Fahs-Anjra", VilleId = "10" },
                new Commune { CommuneId = "4", Name = "Larache", VilleId = "11" },
                new Commune { CommuneId = "5", Name = "Ouezzane", VilleId = "11" },
                new Commune { CommuneId = "7", Name = "Elhajeb", VilleId = "8" },
                new Commune { CommuneId = "8", Name = "Boulmane", VilleId = "9" },
                new Commune { CommuneId = "9", Name = "Taounate", VilleId = "9" },
                new Commune { CommuneId = "10", Name = "Skhirat-Temara", VilleId = "1" },
                new Commune { CommuneId = "11", Name = "Khemissat", VilleId = "1" },
                new Commune { CommuneId = "12", Name = "Sidi kasem", VilleId = "3" },
                new Commune { CommuneId = "13", Name = "Sidi Sliman", VilleId = "2" },
                new Commune { CommuneId = "14", Name = "Mohemmedia", VilleId = "4" },
                new Commune { CommuneId = "15", Name = "Nouacer", VilleId = "4" },
                new Commune { CommuneId = "16", Name = "Sidi Bennour", VilleId = "5" },
                new Commune { CommuneId = "17", Name = "Chichaoua", VilleId = "6" },
                new Commune { CommuneId = "18", Name = "Al Haouz", VilleId = "6" },
                new Commune { CommuneId = "19", Name = "Rehamna", VilleId = "7" },
                new Commune { CommuneId = "20", Name = "Youssofia", VilleId = "7" }

            );
        }
        
    }

}
