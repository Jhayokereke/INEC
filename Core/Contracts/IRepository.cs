using System.Linq;

namespace Core.Contracts
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);
        T GetById(string id);
        IQueryable<T> GetAll();
        bool Update(T entity);
        bool Delete(T entity);
    }
}
