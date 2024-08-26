using Condidat.Domain.Entities;

namespace Condidat.Application.Interfaces
{
    public interface ICondidatRepository
    {
        public Task AddAsync(Condidate condidate);

        Task<List<Condidate>> GetAllAsync();
    }
}
