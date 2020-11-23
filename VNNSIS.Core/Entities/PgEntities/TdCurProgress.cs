using System;
using System.Collections.Generic;

namespace VNNSIS.Core.Entities.PgEntities
{
     public partial class TdCurProgress
     {
          public string OperationCode { get; set; }
          public short OperationSequence { get; set; }
          public string OperationName { get; set; }
          public char? SpecialSign { get; set; }
     }
}
