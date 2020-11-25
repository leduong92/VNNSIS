using System;
using System.Linq.Expressions;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Core.Specification
{
     public class OrderByTmPostMachineOsWithLineNo : BaseSpecification<TmPostMachineOs>
     {
          public OrderByTmPostMachineOsWithLineNo() : base()
          {
               AddOrderBy(x => x.LineNo);
               AddThenBy(x => x.PressNo);
               AddThenBy(x => x.PressName);

          }
     }
}