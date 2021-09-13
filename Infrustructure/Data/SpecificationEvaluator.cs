using System.Linq;
using core.Entities;
using core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrustructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery,iSpecification<TEntity> spec)
        {
            var query = inputQuery;
            if(spec.Criteria != null)
            {
                query =query.Where(spec.Criteria);
            }

            query  = spec.Includes.Aggregate(query, (current, include) => current.Include(include));
            return query;
           
        }
    }
}