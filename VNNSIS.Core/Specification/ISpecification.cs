using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace VNNSIS.Core.Specification
{
     public interface ISpecification<T>
     {
          Expression<Func<T, bool>> Criteria { get; }
          List<Expression<Func<T, object>>> Includes { get; }
          List<string> InclueStrings { get; }
          List<Expression<Func<T, object>>> IncluedsThenBy { get; }
          List<Expression<Func<T, object>>> IncluedsThenByDesc { get; }

          Expression<Func<T, object>> OrderBy { get; }
          Expression<Func<T, object>> OrderByDesending { get; }

          int Take { get; }
          int Skip { get; }
          bool IsPagingEnabled { get; }
     }
}