using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Chess_Game.Infrastructure.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<Chess_GameDbContext>
    {
        public Chess_GameDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Chess_GameDbContext>();
            optionsBuilder.UseSqlServer("Server=STAGIAIRE-PC\\SQLEXPRESS;Database=Chess_games;User Id=Admin;Password=warofchange123;Integrated Security=True;TrustServerCertificate=True;");

            return new Chess_GameDbContext(optionsBuilder.Options);
        }
    }
}
