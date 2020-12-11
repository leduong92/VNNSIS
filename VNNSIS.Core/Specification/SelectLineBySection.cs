using System;
using System.Linq.Expressions;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Entities.SqlEntities;

namespace VNNSIS.Core.Specification
{
     public class SelectLineBySection : BaseSpecification<TdSisSectionLine>
     {
          public SelectLineBySection() : base()
          {
               AddOrderBy(x => x.LineNo);
          }

          public SelectLineBySection(string sectionId) : base(x => x.SectionId == sectionId)
          {
               AddOrderBy(x => x.LineNo);
          }
     }
}