using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_sis_cur_menu")]
     public partial class TdSisCurMenu
     {
          [Column("menu_id")]
          public string MenuId { get; set; }
          [Column("menu_name")]
          public string MenuName { get; set; }
          [Column("id4m")]
          public string Id4m { get; set; }
     }
}
