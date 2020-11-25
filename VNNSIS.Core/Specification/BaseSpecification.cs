using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace VNNSIS.Core.Specification
{
     public class BaseSpecification<T> : ISpecification<T>
     {
          public BaseSpecification()
          {
          }
          public BaseSpecification(Expression<Func<T, bool>> criteria)
          {
               Criteria = criteria;
          }
          public Expression<Func<T, bool>> Criteria { get; }
          public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();
          protected void AddInclued(Expression<Func<T, object>> includeExpression)
          {
               Includes.Add(includeExpression);
          }
          public Expression<Func<T, object>> OrderByDesending { get; private set; }
          protected void AddOrderByDesc(Expression<Func<T, object>> orderByDescExpression)
          {
               OrderByDesending = orderByDescExpression;
          }
          public List<string> InclueStrings { get; } = new List<string>();
          protected void AddIncludeStrings(string includeStrings)
          {
               InclueStrings.Add(includeStrings);
          }
          public List<Expression<Func<T, object>>> IncluedsThenBy { get; private set; } = new List<Expression<Func<T, object>>>();
          protected void AddThenBy(Expression<Func<T, object>> includeThenByExpression)
          {
               IncluedsThenBy.Add(includeThenByExpression);
          }
          public Expression<Func<T, object>> OrderBy { get; private set; }
          protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
          {
               OrderBy = orderByExpression;
          }
          public List<Expression<Func<T, object>>> IncluedsThenByDesc { get; private set; } = new List<Expression<Func<T, object>>>();
          protected void AddThenByDesc(Expression<Func<T, object>> thenByExpression)
          {
               IncluedsThenByDesc.Add(thenByExpression);
          }
          public int Take { get; private set; }
          public int Skip { get; private set; }
          public bool IsPagingEnabled { get; private set; }
          protected void ApplyPaging(int skip, int take)
          {
               Skip = skip;
               Take = take;
               IsPagingEnabled = true;
          }
     }
}