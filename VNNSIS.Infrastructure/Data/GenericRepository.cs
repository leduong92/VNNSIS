using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VNNSIS.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using VNNSIS.Core.Specification;
using VNNSIS.Core.Entities;

namespace VNNSIS.Infrastructure.Data
{
     public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
     {
          private readonly DbContext _context;
          public GenericRepository(DbContext context)
          {
               _context = context;
          }

          public async Task<T> GetByIdAsync(int id)
          {
               return await _context.Set<T>().FindAsync(id);
          }

          public async Task<List<T>> ListAllAsync()
          {
               return await _context.Set<T>().ToListAsync();
          }

          public async Task<T> GetEntityWithSpec(ISpecification<T> spec)
          {
               return await ApplySpecification(spec).FirstOrDefaultAsync();
          }

          public async Task<List<T>> ListAsync(ISpecification<T> spec)
          {
               return await ApplySpecification(spec).ToListAsync();
          }

          public async Task<int> CountAsync(ISpecification<T> spec)
          {
               return await ApplySpecification(spec).CountAsync();
          }

          private IQueryable<T> ApplySpecification(ISpecification<T> spec)
          {
               return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
          }

          public void Add(T entity)
          {
               _context.Set<T>().Add(entity);
          }

          public void Update(T entity)
          {
               _context.Set<T>().Attach(entity);
               _context.Entry(entity).State = EntityState.Modified;
          }

          public void Delete(T entity)
          {
               _context.Set<T>().Remove(entity);
          }

     }
}