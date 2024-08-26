using Chess_Game.Domain.Entities;

namespace Chess_Game.Application.Interfaces
{
    public interface IChess_GameRepository
    {
        Task<List<Game>> GetAllAsync();
    }
}
