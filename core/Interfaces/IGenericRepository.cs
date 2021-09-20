using System.Collections.Generic;
using System.Threading.Tasks;
using core.Entities;
using core.Specifications;

namespace core.Interfaces
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();

        Task<T> GetEntityWithSpec(iSpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(iSpecification<T> spec);

        Task<int> CountAsync(iSpecification<T> spec);
    }
}