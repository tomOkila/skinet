using System.Collections.Generic;
using System.Threading.Tasks;
using core.Entities;

namespace core.Interfaces
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();

    }
}