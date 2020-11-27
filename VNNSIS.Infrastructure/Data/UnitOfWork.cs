using System;
using System.Collections;
using System.Threading.Tasks;
using VNNSIS.Core.Entities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Infrastructure.EF;
using VNNSIS.Infrastructure.Services;

namespace VNNSIS.Infrastructure.Data
{
     public class UnitOfWork : IUnitOfWork
     {
          private readonly PgDbContext _pgContext;
          private readonly SqlDbContext _sqlContext;
          private Hashtable _repository;

          public UnitOfWork(PgDbContext pgContext, SqlDbContext sqlContext)
          {
               _pgContext = pgContext;
               _sqlContext = sqlContext;
               MenuMasters = new MenuService(_sqlContext, _pgContext);
          }
          public IMenuService MenuMasters { get; private set; }
          public async Task<int> PgComplete()
          {
               return await _pgContext.SaveChangesAsync();
          }

          public void Dispose()
          {
               if (_pgContext != null)
               {
                    _pgContext.Dispose();
               }
          }
          public IGenericRepository<TEntity> PgRepository<TEntity>() where TEntity : BaseEntity
          {
               if (_repository == null)
                    _repository = new Hashtable();

               var type = typeof(TEntity).Name;

               if (!_repository.ContainsKey(type))
               {
                    var repositoryType = typeof(GenericRepository<>);
                    var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _pgContext);

                    _repository.Add(type, repositoryInstance);
               }
               return (IGenericRepository<TEntity>)_repository[type];
          }
          public IGenericRepository<TEntity> SqlRepository<TEntity>() where TEntity : BaseEntity
          {
               if (_repository == null)
                    _repository = new Hashtable();

               var type = typeof(TEntity).Name;

               if (!_repository.ContainsKey(type))
               {
                    var repositoryType = typeof(GenericRepository<>);
                    var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _sqlContext);

                    _repository.Add(type, repositoryInstance);
               }
               return (IGenericRepository<TEntity>)_repository[type];
          }
     }
}