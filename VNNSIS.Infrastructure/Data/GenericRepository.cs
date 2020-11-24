using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VNNSIS.Core.Entities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Infrastructure.EF;

namespace VNNSIS.Infrastructure.Data
{
     public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
     {

          private readonly PgDbContext _pgContext;

          public GenericRepository(PgDbContext pgContext)
          {
               _pgContext = pgContext;
          }

          public async Task<IReadOnlyList<T>> ListAllAsync()
          {
               return await _pgContext.Set<T>().ToListAsync();
          }

          public async Task<T> GetByIdAsync(string id)
          {
               return await _pgContext.Set<T>().FindAsync(id);
          }
     }
}