using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_cur_progress")]
     public class TdCurProgress
     {
          [Column("operation_code")]
          public string OperationCode { get; set; }
          [Column("operation_sequence")]
          public short OperationSequence { get; set; }
          [Column("operation_name")]
          public string OperationName { get; set; }
          [Column("special_sign")]
          public char? SpecialSign { get; set; }
     }
}
