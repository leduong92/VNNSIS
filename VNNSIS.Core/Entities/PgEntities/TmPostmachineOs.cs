using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("tm_postmachine_os")]
     public class TmPostMachineOs : BaseEntity
     {
          [Column("line_no")]
          public string LineNo { get; set; }
          [Column("press_no")]
          public string PressNo { get; set; }
          [Column("press_name")]
          public string PressName { get; set; }
          [Column("location_cd")]
          public string LocationCd { get; set; }
          [Column("temperature")]
          public int? Temperature { get; set; }
          [Column("plc_m")]
          public string PlcM { get; set; }
          [Column("plc_m1")]
          public string PlcM1 { get; set; }
          [Column("plc_m2")]
          public string PlcM2 { get; set; }
          [Column("ip")]
          public string Ip { get; set; }
          [Column("status")]
          public int Status { get; set; }
          [Column("time_use")]
          public string TimeUse { get; set; }
          [Column("entry_date")]
          public string EntryDate { get; set; }
          [Column("update_date")]
          public string UpdateDate { get; set; }
          [Column("plc_m3")]
          public string PlcM3 { get; set; }
          [Column("post_cure_type")]
          public int PostCureType { get; set; }
          [Column("mold_type")]
          public int MoldType { get; set; }
          [Column("trim_type")]
          public int? TrimType { get; set; }
          [Column("devices")]
          public int Devices { get; set; }
          [Column("memo")]
          public string Memo { get; set; }
     }
}
