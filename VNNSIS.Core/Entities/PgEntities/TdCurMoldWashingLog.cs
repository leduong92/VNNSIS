using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_cur_mold_washing_log")]
     public partial class TdCurMoldWashingLog : BaseEntity
     {
          [Column("mold_up")]
          public string MoldUp { get; set; }
          [Column("mold_down")]
          public string MoldDown { get; set; }
          [Column("status")]
          public string Status { get; set; }
          [Column("mold_job")]
          public string MoldJob { get; set; }
          [Column("old_mold_job")]
          public string OldMoldJob { get; set; }
          [Column("entry_date")]
          public string EntryDate { get; set; }
          [Column("entry_time")]
          public string EntryTime { get; set; }
          [Column("entry_user")]
          public string EntryUser { get; set; }
          [Column("group_id")]
          public string GroupId { get; set; }
          [Column("location_cd")]
          public string LocationCd { get; set; }
     }
}
