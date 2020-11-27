using System;
using System.Threading.Tasks;
using VNNSIS.Core.Entities;

namespace VNNSIS.Core.Interfaces
{
     public interface IUnitOfWork : IDisposable
     {
          IGenericRepository<TEntity> PgRepository<TEntity>() where TEntity : BaseEntity;
          IGenericRepository<TEntity> SqlRepository<TEntity>() where TEntity : BaseEntity;
          Task<int> PgComplete();

          IMenuService MenuMasters { get; }

     }
}