using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VNNSIS.Core.Entities;
using VNNSIS.Core.Specification;

namespace VNNSIS.Core.Interfaces
{
     public interface IGenericRepository<T> where T : BaseEntity
     {
          IQueryable<T> FindAll(Expression<Func<T, bool>> pression = null);

          IQueryable<T> FindAllWithSpecification(ISpecification<T> spec);
          Task<T> GetByIdAsync(int id);
          Task<List<T>> ListAllAsync();
          Task<T> GetEntityWithSpec(ISpecification<T> spec = null);
          Task<List<T>> ListAsync(ISpecification<T> spec = null);
          Task<int> CountAsync(ISpecification<T> spec);
          void Add(T entity);
          void Update(T entity);
          void Delete(T entity);

     }
}