using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.ViewModels
{
     public class UserMachineVm
     {

          [Column("line_no")]
          public string LineNo { get; set; }
          [Column("press_no")]
          [Key]
          public string PressNo { get; set; }
          [Column("plc_m")]
          public string PlcM { get; set; }
          [Column("plc_m1")]
          public string PlcM1 { get; set; }
          [Column("plc_m2")]
          public string PlcM2 { get; set; }
          [Column("ip")]
          public string Ip { get; set; }
          [Column("status")]
          public int? Status { get; set; }

          [Column("mold_type")]
          public int? MoldType { get; set; }
          [Column("trim_type")]
          public int? TrimType { get; set; }
          [Column("start_date")]
          public string StartDate { get; set; }
          [Column("start_time")]
          public string StartTime { get; set; }
          [Column("start_user")]
          public string StartUser { get; set; }
          [Column("start_date_01")]
          public string StartDate01 { get; set; }
          [Column("start_time_01")]
          public string StartTime01 { get; set; }
          [Column("start_user_01")]
          public string StartUser01 { get; set; }
          [Column("menu_name")]
          public string MenuName { get; set; }

     }
}