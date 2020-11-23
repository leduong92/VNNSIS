using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_sis_cur_record")]
     public partial class TdSisCurRecord : BaseEntity
     {
          [Column("line_no")]
          public string LineNo { get; set; }
          [Column("press_no")]
          public string PressNo { get; set; }
          [Column("type")]
          public string Type { get; set; }
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
          [Column("reset_date")]
          public string ResetDate { get; set; }
          [Column("reset_time")]
          public string ResetTime { get; set; }
          [Column("reset_user")]
          public string ResetUser { get; set; }
          [Column("active")]
          public string Active { get; set; }
          [Column("shift")]
          public string Shift { get; set; }
          [Column("error_type")]
          public string ErrorType { get; set; }
     }
}
