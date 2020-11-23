using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_sis_section_line")]
     public partial class TdSisSectionLine
     {
          [Column("line_no")]
          public string LineNo { get; set; }
          [Column("section_id")]
          public string SectionId { get; set; }

     }
}
