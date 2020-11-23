using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("td_sis_section_master")]
     public partial class TdSisSectionMaster
     {
          private string sectionId;
          [Column("section_id")]
          public string SectionId
          {
               get { return sectionId.ToString().Trim() ?? null; }
               set { sectionId = value.ToString().Trim(); }
          }
          private string sectionName;
          [Column("section_name")]
          public string SectionName
          {
               get { return sectionName.ToString().Trim() ?? null; }
               set { sectionName = value.ToString().Trim(); }
          }
     }
}
