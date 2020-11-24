using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_sis_error_menu")]
     public class TdSisErrorMenu
     {
          private string errorId;
          [Column("error_id")]
          public string ErrorId
          {
               get { return errorId.ToString().Trim() ?? null; }
               set { errorId = value.ToString().Trim(); }
          }
          private string errorMenu;
          [Column("error_menu")]
          public string ErrorMenu
          {
               get { return errorMenu.ToString().Trim() ?? null; }
               set { errorMenu = value.ToString().Trim(); }
          }
          private string type;
          [Column("type")]
          public string Type
          {
               get { return type.ToString().Trim() ?? null; }
               set { type = value.ToString().Trim(); }
          }
     }
}
