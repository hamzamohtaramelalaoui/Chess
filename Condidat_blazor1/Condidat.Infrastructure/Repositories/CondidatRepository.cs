using Microsoft.EntityFrameworkCore;
using Condidat.Domain.Entities;
using Condidat.Application.Interfaces;
using Condidat.Infrastructure.Context;

namespace Condidat.Infrastructure.Repositories
{
    public class CondidatRepository : ICondidatRepository
    {
        private readonly CondidatDbContext context;

        public CondidatRepository(IDbContextFactory<CondidatDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task AddAsync(Condidate condidate)
        {
            context.Condidats.Add(condidate);
            await context.SaveChangesAsync();
        }

        public Task<List<Condidate>> GetAllAsync()
        {
            var condidats = context.Condidats.ToListAsync();
            return condidats;
        }
    }

}
