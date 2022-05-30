using Models;

namespace Core.Contracts
{
    public interface IElectionRepository : IAsyncRepository<Election>, IRepository<Election>
    {
    }
}
