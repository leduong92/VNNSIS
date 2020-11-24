using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using VNNSIS.Core.Entities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Infrastructure.EF;

namespace VNNSIS.Infrastructure.Data
{
     public class UnitOfWork : IUnitOfWork
     {
          private readonly SqlDbContext _sqlContext;
          private readonly PgDbContext _pgContext;
          private Hashtable _repository;
          public UnitOfWork(SqlDbContext sqlContext, PgDbContext pgContext)
          {
               _sqlContext = sqlContext;
               _pgContext = pgContext;
          }

          public async Task<int> SqlComplete()
          {
               return await _sqlContext.SaveChangesAsync();
          }
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

               if (_sqlContext != null)
               {
                    _sqlContext.Dispose();
               }
          }
          public IGenericRepository<TEntity> PgRepository<TEntity>() where TEntity : BaseEntity
          {
               if (_repository == null)
                    _repository = new Hashtable();

               //var type = typeof(TEntity).Name; //truong hop ten model trung voi ten trong db

               var models = _pgContext.Model;

               var entityTypes = models.GetEntityTypes().First(t => t.ClrType == typeof(TEntity));

               var tableNameAnnotation = entityTypes.GetAnnotation("Relational:TableName");

               var type = tableNameAnnotation.Value.ToString();

               if (_repository.ContainsKey(type))
               {
                    var repositoryType = typeof(IGenericRepository<>);
                    var reporitoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _pgContext);
                    _repository.Add(type, reporitoryInstance);

               }
               return (IGenericRepository<TEntity>)_repository[type];
          }

          public string GetTableName<T>(PgDbContext context) where T : class
          {
               // We need dbcontext to access the models
               var models = context.Model;

               // Get all the entity types information
               var entityTypes = models.GetEntityTypes();

               // T is Name of class
               var entityTypeOfT = entityTypes.First(t => t.ClrType == typeof(T));

               var tableNameAnnotation = entityTypeOfT.GetAnnotation("Relational:TableName");
               var TableName = tableNameAnnotation.Value.ToString();
               return TableName;
          }
     }
}