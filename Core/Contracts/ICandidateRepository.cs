using Models;

namespace Core.Contracts
{
    public interface ICandidateRepository : IAsyncRepository<Candidate>, IRepository<Candidate>
    {
    }
}
