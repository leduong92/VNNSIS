using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_sis_section_master")]
     public partial class TdSisSectionMaster
     {
          [Column("section_id")]
          public string SectionId { get; set; }
          [Column("section_name")]
          public string SectionName { get; set; }
     }
}
