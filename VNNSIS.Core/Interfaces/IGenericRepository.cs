using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.Entities;
using VNNSIS.Core.Specification;

namespace VNNSIS.Core.Interfaces
{
     public interface IGenericRepository<T> where T : BaseEntity
     {
          Task<IReadOnlyList<T>> ListAllAsync();
          Task<T> GetByIdAsync(string id);

          Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
          Task<T> GetEntityWithSpec(ISpecification<T> spec);

     }
}