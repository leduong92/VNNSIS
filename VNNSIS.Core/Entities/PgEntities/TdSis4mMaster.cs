using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_sis_4m_master")]
     public partial class TdSis4mMaster
     {
          [Column("id")]
          public string Id { get; set; }
          [Column("menu_name")]
          public string MenuName { get; set; }
     }
}
