using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("si_pro_error_master")]
     public partial class SiProErrorMaster
     {
          private string errorId;
          [Column("error_id")]
          public string ErrorId
          {
               get { return errorId.ToString().Trim() ?? null; }
               set { errorId = value.ToString().Trim(); }
          }
          private string errorName;
          [Column("error_name")]
          public string ErrorName
          {
               get { return errorName.ToString().Trim() ?? null; }
               set { errorName = value.ToString().Trim(); }
          }
          private string errorNameJp;
          [Column("error_name_jp")]
          public string ErrorNameJp
          {
               get { return errorNameJp.ToString().Trim() ?? null; }
               set { errorNameJp = value.ToString().Trim(); }
          }
          private string errorNamEn;
          [Column("error_name_en")]
          public string ErrorNameEn
          {
               get { return errorNamEn.ToString().Trim() ?? null; }
               set { errorNamEn = value.ToString().Trim(); }
          }
          private string entryDate;
          [Column("entry_date")]
          public string EntryDate
          {
               get { return entryDate.ToString().Trim() ?? null; }
               set { entryDate = value.ToString().Trim(); }
          }
          private string entryTime;
          [Column("entry_time")]
          public string EntryTime
          {
               get { return entryTime.ToString().Trim() ?? null; }
               set { entryTime = value.ToString().Trim(); }
          }
          private string entryUser;
          [Column("entry_user")]
          public string EntryUser
          {
               get { return entryUser.ToString().Trim() ?? null; }
               set { entryUser = value.ToString().Trim(); }
          }
          private string location;
          [Column("location")]
          public string Location
          {
               get { return location.ToString().Trim() ?? null; }
               set { location = value.ToString().Trim(); }
          }
          private string status;
          [Column("status")]
          public string Status
          {
               get { return location.ToString().Trim() ?? null; }
               set { location = value.ToString().Trim(); }
          }
          [Column("error_max")]
          public double? ErrorMax { get; set; }
     }
}
