using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_job_prmold_os")]
     public partial class TdJobPrmoldOs : BaseEntity
     {
          [Column("job_order_no")]
          public string JobOrderNo { get; set; }
          [Column("line_no")]
          public string LineNo { get; set; }
          [Column("press_no")]
          public string PressNo { get; set; }
          [Column("press_name")]
          public string PressName { get; set; }
          [Column("rubber_count")]
          public short? RubberCount { get; set; }
          [Column("metalcase_count")]
          public short? MetalcaseCount { get; set; }
          [Column("rubber_total")]
          public short? RubberTotal { get; set; }
          [Column("metalcase_total")]
          public short? MetalcaseTotal { get; set; }
          [Column("status")]
          public short? Status { get; set; }
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
          [Column("washing_status")]
          public int? WashingStatus { get; set; }
          [Column("start_washing_date")]
          public string StartWashingDate { get; set; }
          [Column("start_washing_time")]
          public string StartWashingTime { get; set; }
          [Column("start_washing_user")]
          public string StartWashingUser { get; set; }
          [Column("start_date_01")]
          public string StartDate01 { get; set; }
          [Column("start_time_01")]
          public string StartTime01 { get; set; }
          [Column("start_user_01")]
          public string StartUser01 { get; set; }
     }
}
