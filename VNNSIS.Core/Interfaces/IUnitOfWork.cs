using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.Entities;

namespace VNNSIS.Core.Interfaces
{
     public interface IUnitOfWork : IDisposable
     {
          IGenericRepository<TEntity> SqlRepository<TEntity>() where TEntity : BaseEntity;
          IGenericRepository<TEntity> PgRepository<TEntity>() where TEntity : BaseEntity;
          Task<int> Complete();
     }
}