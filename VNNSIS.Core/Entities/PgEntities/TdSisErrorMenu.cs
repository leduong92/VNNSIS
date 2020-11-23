using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_sis_error_menu")]
     public partial class TdSisErrorMenu
     {
          [Column("error_id")]
          public string ErrorId { get; set; }
          [Column("error_menu")]
          public string ErrorMenu { get; set; }
          [Column("type")]
          public string Type { get; set; }
     }
}
