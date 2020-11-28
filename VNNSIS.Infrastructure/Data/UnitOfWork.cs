using System;
using System.Collections;
using System.Threading.Tasks;
using VNNSIS.Core.Entities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Infrastructure.Data;
using VNNSIS.Infrastructure.EF;
using VNNSIS.Infrastructure.Repository;

namespace Infrastructure.Data
{
     public class UnitOfWork : IUnitOfWork
     {
          public SqlDbContext _sqlContext { get; set; }
          public PgDbContext _pgContext { get; set; }
          private Hashtable _repositories;
          public UnitOfWork(SqlDbContext sqlContext, PgDbContext pgContext)
          {
               _sqlContext = sqlContext;
               _pgContext = pgContext;
               menuRepository = new MenuRepository(_sqlContext, _pgContext);
          }

          public IMenuRepository menuRepository { get; set; }
          public async Task<int> Complete()
          {
               return await _sqlContext.SaveChangesAsync();
          }

          public void Dispose()
          {
               _sqlContext.Dispose();
          }

          public IGenericRepository<TEntity> SqlRepository<TEntity>() where TEntity : BaseEntity
          {
               if (_repositories == null) _repositories = new Hashtable();

               var type = typeof(TEntity).Name;

               if (!_repositories.ContainsKey(type))
               {
                    var repositoryType = typeof(GenericRepository<>);
                    var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _sqlContext);

                    _repositories.Add(type, repositoryInstance);
               }

               return (IGenericRepository<TEntity>)_repositories[type];
          }
          public IGenericRepository<TEntity> PgRepository<TEntity>() where TEntity : BaseEntity
          {
               if (_repositories == null) _repositories = new Hashtable();

               var type = typeof(TEntity).Name;

               if (!_repositories.ContainsKey(type))
               {
                    var repositoryType = typeof(GenericRepository<>);
                    var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _pgContext);

                    _repositories.Add(type, repositoryInstance);
               }

               return (IGenericRepository<TEntity>)_repositories[type];
          }
     }
}