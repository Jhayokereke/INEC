using Models;

namespace Core.Contracts
{
    public interface IPartyRepository : IAsyncRepository<Party>, IRepository<Party>
    {
    }
}
