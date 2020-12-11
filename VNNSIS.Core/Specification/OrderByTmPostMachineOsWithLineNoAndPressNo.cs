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
          public OrderByTmPostMachineOsWithLineNo(string line) : base(x => x.LineNo == line)
          {
               AddOrderBy(x => x.LineNo);
               AddThenBy(x => x.PressNo);
               AddThenBy(x => x.PressName);
          }
          public OrderByTmPostMachineOsWithLineNo(string lineNo, string pressNo) : base(x => x.LineNo == lineNo && x.PressName == pressNo)
          {

          }
     }
}