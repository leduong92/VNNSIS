using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using VNNSIS.Core.Entities;
using VNNSIS.Core.Specification;

namespace VNNSIS.Infrastructure.Data
{
     public static class SpecificationEvalutor<TEntity> where TEntity : BaseEntity
     {
          public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> spec)
          {
               var query = inputQuery;

               IOrderedQueryable<TEntity> output = null;

               if (spec.Criteria != null)
               {
                    query = query.Where(spec.Criteria);
               }

               if (spec.GroupBy != null)
               {
                    query = query.GroupBy(spec.GroupBy).SelectMany(x => x);
               }

               if (spec.OrderBy != null)
               {
                    query = query.OrderBy(spec.OrderBy);
               }

               if (spec.OrderByDesending != null)
               {
                    query = query.OrderByDescending(spec.OrderByDesending);
               }

               if (spec.IncluedsThenBy != null)
               {
                    foreach (var order in spec.IncluedsThenBy)
                    {
                         var orderedQuery = query as IOrderedQueryable<TEntity>;
                         query = orderedQuery.ThenBy(order);
                    }
               }
               if (spec.IncluedsThenByDesc != null)
               {
                    foreach (var orderDesc in spec.IncluedsThenByDesc)
                    {
                         var orderedQuery = query as IOrderedQueryable<TEntity>;
                         query = orderedQuery.ThenBy(orderDesc);
                    }
               }

               if (spec.IsPagingEnabled)
               {
                    query = query.Skip(spec.Skip).Take(spec.Take);
               }

               query = spec.InclueStrings.Aggregate(query, (curent, include) => curent.Include(include));
               query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

               return output ?? query;
          }
     }
}