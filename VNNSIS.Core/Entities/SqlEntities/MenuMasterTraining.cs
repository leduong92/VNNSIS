using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace VNNSIS.Core.Entities.SqlEntities
{
     public partial class MenuMasterTraining : BaseEntity
     {
          public int MenuIdentity { get; set; }
          public string MenuId { get; set; }
          public string MenuName { get; set; }
          public string ParentMenuId { get; set; }
          public string UserRole { get; set; }
          public string MenuFileName { get; set; }
          public string MenuUrl { get; set; }
          [Column("USE_YN")]
          public string UseYn { get; set; }
          public DateTime? CreatedDate { get; set; }
          public string MenuClass { get; set; }
          public string MenuText { get; set; }
          public string MenuImg { get; set; }
          [Column("MenuName_Vn")]
          public string MenuNameVn { get; set; }
          [Column("Order_id")]
          public short? OrderId { get; set; }
     }
}
