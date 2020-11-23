using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("si_pro_error_master")]
     public partial class SiProErrorMaster
     {
          [Column("error_id")]
          public string ErrorId { get; set; }
          [Column("error_name")]
          public string ErrorName { get; set; }
          [Column("error_name_jp")]
          public string ErrorNameJp { get; set; }
          [Column("error_name_en")]
          public string ErrorNameEn { get; set; }
          [Column("entry_date")]
          public string EntryDate { get; set; }
          [Column("entry_time")]
          public string EntryTime { get; set; }
          [Column("entry_user")]
          public string EntryUser { get; set; }
          [Column("location")]
          public string Location { get; set; }
          [Column("status")]
          public string Status { get; set; }
          [Column("error_max")]
          public double? ErrorMax { get; set; }
     }
}
