using Chess_Game.Application.Interfaces;
using Chess_Game.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Chess_Game.Domain.Entities;

namespace Chess_Game.Infrastructure.Repositories
{
    public class Chess_GameRepository : IChess_GameRepository
    {
        private readonly Chess_GameDbContext _context;

        public Chess_GameRepository(Chess_GameDbContext context)
        {
            _context = context;
        }

        public async Task<List<Game>> GetAllAsync()
        {
            return await _context.Games.ToListAsync();
        }
    }

    
}
