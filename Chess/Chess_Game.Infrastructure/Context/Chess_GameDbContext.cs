using Microsoft.EntityFrameworkCore;
using Chess_Game.Domain.Entities;

namespace Chess_Game.Infrastructure.Context
{
    public class Chess_GameDbContext : DbContext
    {
        public Chess_GameDbContext(DbContextOptions <Chess_GameDbContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .HasKey(cg => cg.id_Game);
        }
    }
}
