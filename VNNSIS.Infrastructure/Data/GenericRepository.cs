using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VNNSIS.Core.Entities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.Specification;
using VNNSIS.Infrastructure.EF;

namespace VNNSIS.Infrastructure.Data
{
     public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
     {

          private readonly DbContext _context;

          public GenericRepository(DbContext context)
          {
               _context = context;
          }

          public async Task<IReadOnlyList<T>> ListAllAsync()
          {
               return await _context.Set<T>().ToListAsync();
          }

          public async Task<T> GetByIdAsync(string id)
          {
               return await _context.Set<T>().FindAsync(id);
          }

          public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
          {
               return await ApplySpecification(spec).ToListAsync();
          }

          private IQueryable<T> ApplySpecification(ISpecification<T> spec)
          {
               return SpecificationEvalutor<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
          }

          public async Task<T> GetEntityWithSpec(ISpecification<T> spec)
          {
               return await ApplySpecification(spec).FirstOrDefaultAsync();
          }


     }
}