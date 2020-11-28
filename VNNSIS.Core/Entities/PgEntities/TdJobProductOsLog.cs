using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_job_product_os_log")]
     public partial class TdJobProductOsLog
     {
          [Column("job_order_no")]
          public string JobOrderNo { get; set; }
          [Column("line_no")]
          public string LineNo { get; set; }
          [Column("press_no")]
          public string PressNo { get; set; }
          [Column("mold_status")]
          public short MoldStatus { get; set; }
          [Column("trim_status")]
          public short TrimStatus { get; set; }
          [Column("entry_date")]
          public string EntryDate { get; set; }
          [Column("entry_time")]
          public string EntryTime { get; set; }
          [Column("entry_user")]
          public string EntryUser { get; set; }
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
          [Column("reject_date")]
          public string RejectDate { get; set; }
          [Column("reject_time")]
          public string RejectTime { get; set; }
          [Column("reject_user")]
          public string RejectUser { get; set; }
          [Column("washing_date")]
          public string WashingDate { get; set; }
          [Column("washing_time")]
          public string WashingTime { get; set; }
          [Column("washing_user")]
          public string WashingUser { get; set; }
          [Column("memo")]
          public string Memo { get; set; }
          [Column("start_washing_date")]
          public string StartWashingDate { get; set; }
          [Column("start_washing_time")]
          public string StartWashingTime { get; set; }
          [Column("start_washing_user")]
          public string StartWashingUser { get; set; }
     }
}
