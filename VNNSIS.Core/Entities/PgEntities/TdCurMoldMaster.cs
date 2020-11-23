using System;
using System.Collections.Generic;

namespace VNNSIS.Core.Entities.PgEntities
{

     public partial class TdCurMoldMaster
     {
          public string MoldUp { get; set; }
          public string MoldDown { get; set; }
          public string MoldCode { get; set; }
          public string MoldNo { get; set; }
          public string CavNo { get; set; }
          public char? Type { get; set; }
          public string SeriNo { get; set; }
          public string OtherInfo { get; set; }
          public string EntryDate { get; set; }
          public string EntryTime { get; set; }
          public string EntryUser { get; set; }
          public string UpdateDate { get; set; }
          public string UpdateTime { get; set; }
          public string UpdateUser { get; set; }
          public string Status { get; set; }
          public string MoldJob { get; set; }
          public string MoldRackNo { get; set; }
          public int? CycleCur { get; set; }
          public int? CycleTotal { get; set; }
          public int? CycleSpec { get; set; }
          public string MoldRackTmp { get; set; }
          public string GroupId { get; set; }
          public string LocationCd { get; set; }
     }
}
