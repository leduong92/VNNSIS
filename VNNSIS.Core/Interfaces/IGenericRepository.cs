using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.Entities;

namespace VNNSIS.Core.Interfaces
{
     public interface IGenericRepository<T> where T : BaseEntity
     {
          Task<IReadOnlyList<T>> ListAllAsync();
          Task<T> GetByIdAsync(string id);

     }
}