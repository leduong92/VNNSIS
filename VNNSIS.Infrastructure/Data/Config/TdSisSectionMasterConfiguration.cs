using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config
{
     public class TdSisSectionMasterConfiguration : IEntityTypeConfiguration<TdSisSectionMaster>
     {
          public void Configure(EntityTypeBuilder<TdSisSectionMaster> builder)
          {
               builder.ToTable("td_sis_section_master");
               builder.HasKey(x => x.SectionId);
          }
     }
}