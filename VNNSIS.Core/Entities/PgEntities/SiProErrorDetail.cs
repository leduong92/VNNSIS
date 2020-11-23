using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("si_pro_error_detail")]
     public partial class SiProErrorDetail
     {
          [Column("progress_operation_seq")]
          public short ProgressOperationSeq { get; set; }
          private string errorId;
          [Column("error_id")]
          public string ErrorId
          {
               get { return errorId.ToString().Trim() ?? null; }
               set { errorId = value.ToString().Trim(); }
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
          [Column("status")]
          public string Status { get; set; } = "0";

          private string department;
          [Column("department")]
          public string Department
          {
               get { return department.ToString().Trim() ?? null; }
               set { department = value.ToString().Trim(); }
          }
          private string area;
          [Column("area")]
          public string Area
          {
               get { return area.ToString().Trim() ?? null; }
               set { area = value.ToString().Trim(); }
          }
          private string programId;
          [Column("program_id")]
          public string ProgramId
          {
               get { return programId.ToString().Trim() ?? null; }
               set { programId = value.ToString().Trim(); }
          }
          [Column("error_dept_id")]
          public string ErrorDeptId { get; set; }
          [Column("order_id")]
          public short? OrderId { get; set; }
     }
}
