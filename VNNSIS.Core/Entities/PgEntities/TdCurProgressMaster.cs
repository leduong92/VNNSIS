using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_cur_progress_master")]
     public class TdCurProgressMaster : BaseEntity
     {
          [Column("finished_goods_code")]
          public string FinishedGoodsCode { get; set; }
          [Column("operation_code")]
          public string OperationCode { get; set; }
          [Column("operation_name")]
          public string OperationName { get; set; }
          [Column("operation_sequence")]
          public short OperationSequence { get; set; }
          [Column("check_process_sign")]
          public string CheckProcessSign { get; set; }
     }
}
