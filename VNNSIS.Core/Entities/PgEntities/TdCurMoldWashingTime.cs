using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_cur_mold_washing_time")]
     public partial class TdCurMoldWashingTime
     {
          [Column("line_no")]
          public string LineNo { get; set; }
          [Column("washing_time")]
          public string WashingTime { get; set; }
          [Column("type_name")]
          public string TypeName { get; set; }
     }
}
