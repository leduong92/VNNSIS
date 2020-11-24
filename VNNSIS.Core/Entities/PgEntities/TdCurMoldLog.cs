using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_cur_mold_log")]
     public class TdCurMoldLog
     {
          [Column("mold_up")]
          public string MoldUp { get; set; }
          [Column("mold_down")]
          public string MoldDown { get; set; }
          [Column("setup_date")]
          public string SetupDate { get; set; }
          [Column("setup_time")]
          public string SetupTime { get; set; }
          [Column("setup_user")]
          public string SetupUser { get; set; }
          [Column("prepare_date")]
          public string PrepareDate { get; set; }
          [Column("prepare_time")]
          public string PrepareTime { get; set; }
          [Column("prepare_user")]
          public string PrepareUser { get; set; }
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
          [Column("pro_user")]
          public string ProUser { get; set; }
          [Column("status")]
          public string Status { get; set; }
          [Column("mold_job")]
          public string MoldJob { get; set; }
          [Column("confirm_user")]
          public string ConfirmUser { get; set; }
          [Column("mold_rack_no")]
          public string MoldRackNo { get; set; }
          [Column("receive_wash_date")]
          public string ReceiveWashDate { get; set; }
          [Column("receive_wash_time")]
          public string ReceiveWashTime { get; set; }
          [Column("receive_wash_user")]
          public string ReceiveWashUser { get; set; }
          [Column("receive_wash_pro_user")]
          public string ReceiveWashProUser { get; set; }
          [Column("start_wash_date")]
          public string StartWashDate { get; set; }
          [Column("start_wash_time")]
          public string StartWashTime { get; set; }
          [Column("start_wash_user")]
          public string StartWashUser { get; set; }
          [Column("end_wash_date")]
          public string EndWashDate { get; set; }
          [Column("end_wash_time")]
          public string EndWashTime { get; set; }
          [Column("end_wash_user")]
          public string EndWashUser { get; set; }
          [Column("old_mold_job")]
          public string OldMoldJob { get; set; }
          [Column("delivery_date")]
          public string DeliveryDate { get; set; }
          [Column("delivery_time")]
          public string DeliveryTime { get; set; }
          [Column("delivery_user")]
          public string DeliveryUser { get; set; }
          [Column("group_id")]
          public string GroupId { get; set; }
          [Column("end_prod_date")]
          public string EndProdDate { get; set; }
          [Column("end_prod_time")]
          public string EndProdTime { get; set; }
          [Column("end_prod_user")]
          public string EndProdUser { get; set; }
          [Column("location_cd")]
          public string LocationCd { get; set; }
     }
}
