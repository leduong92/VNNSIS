using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_cur_progress_check")]
     public partial class TdCurProgressCheck
     {
          [Column("job_order_no")]
          public string JobOrderNo { get; set; }
          [Column("finished_goods_code")]
          public string FinishedGoodsCode { get; set; }
          [Column("operation_code")]
          public string OperationCode { get; set; }
          [Column("operation_sequence")]
          public short OperationSequence { get; set; }
          [Column("order_date")]
          public int? OrderDate { get; set; }
          [Column("finished_qty")]
          public int? FinishedQty { get; set; }
          [Column("ng_qty")]
          public int? NgQty { get; set; }
          [Column("start_date")]
          public string StartDate { get; set; }
          [Column("start_time")]
          public string StartTime { get; set; }
          [Column("start_user")]
          public string StartUser { get; set; }
          [Column("end_date")]
          public string EndDate { get; set; }
          [Column("end_time")]
          public string EndTime { get; set; }
          [Column("end_user")]
          public string EndUser { get; set; }
          [Column("ng_date")]
          public string NgDate { get; set; }
          [Column("ng_time")]
          public string NgTime { get; set; }
          [Column("ng_user")]
          public string NgUser { get; set; }
          [Column("status")]
          public short Status { get; set; }
          [Column("machine_no")]
          public string MachineNo { get; set; }
          [Column("confirm_date")]
          public string ConfirmDate { get; set; }
          [Column("confirm_time")]
          public string ConfirmTime { get; set; }
          [Column("confirm_user")]
          public string ConfirmUser { get; set; }
     }
}
