using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_cur_mold_master")]
     public partial class TdCurMoldMaster
     {
          [Column("mold_up")]
          public string MoldUp { get; set; }
          [Column("mold_down")]
          public string MoldDown { get; set; }
          [Column("mold_code")]
          public string MoldCode { get; set; }
          [Column("mold_no")]
          public string MoldNo { get; set; }
          [Column("cav_no")]
          public string CavNo { get; set; }
          [Column("type")]
          public string Type { get; set; }
          [Column("seri_no")]
          public string SeriNo { get; set; }
          [Column("other_info")]
          public string OtherInfo { get; set; }
          [Column("entry_date")]
          public string EntryDate { get; set; }
          [Column("entry_time")]
          public string EntryTime { get; set; }
          [Column("entry_user")]
          public string EntryUser { get; set; }
          [Column("update_date")]
          public string UpdateDate { get; set; }
          [Column("update_time")]
          public string UpdateTime { get; set; }
          [Column("update_user")]
          public string UpdateUser { get; set; }
          [Column("status")]
          public string Status { get; set; }
          [Column("mold_job")]
          public string MoldJob { get; set; }
          [Column("mold_rack_no")]
          public string MoldRackNo { get; set; }
          [Column("cycle_cur")]
          public int? CycleCur { get; set; }
          [Column("cycle_total")]
          public int? CycleTotal { get; set; }
          [Column("cycle_spec")]
          public int? CycleSpec { get; set; }
          [Column("mold_rack_tmp")]
          public string MoldRackTmp { get; set; }
          [Column("group_id")]
          public string GroupId { get; set; }
          [Column("location_cd")]
          public string LocationCd { get; set; }
     }
}
