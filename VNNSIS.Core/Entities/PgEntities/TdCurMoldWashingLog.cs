using System;
using System.Collections.Generic;

namespace VNNSIS.Core.Entities.PgEntities
{
     public partial class TdCurMoldWashingLog : BaseEntity
     {
          public string MoldUp { get; set; }
          public string MoldDown { get; set; }
          public char? Status { get; set; }
          public string MoldJob { get; set; }
          public string OldMoldJob { get; set; }
          public string EntryDate { get; set; }
          public string EntryTime { get; set; }
          public string EntryUser { get; set; }
          public string GroupId { get; set; }
          public string LocationCd { get; set; }
     }
}
