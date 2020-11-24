using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_sis_cur_menu")]
     public class TdSisCurMenu : BaseEntity
     {
          private string menuId;
          [Column("menu_id")]
          public string MenuId
          {
               get { return menuId.ToString().Trim() ?? null; }
               set { menuId = value.ToString().Trim(); }
          }
          private string menuName;
          [Column("menu_name")]
          public string MenuName
          {
               get { return menuName.ToString().Trim() ?? null; }
               set { menuName = value.ToString().Trim(); }
          }
          [Column("id_4m")]
          public string Id4m { get; set; }
     }
}
