using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_sis_section_line")]
     public class TdSisSectionLine
     {
          private string lineNo;
          [Column("line_no")]
          public string LineNo
          {
               get { return lineNo.ToString().Trim() ?? null; }
               set { lineNo = value.ToString().Trim(); }
          }
          private string sectionId;
          [Column("section_id")]
          public string SectionId
          {
               get { return sectionId.ToString().Trim() ?? null; }
               set { sectionId = value.ToString().Trim(); }
          }

     }
}
