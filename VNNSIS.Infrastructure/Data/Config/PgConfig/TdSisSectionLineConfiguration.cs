using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.PgConfig
{
     public class TdSisSectionLineConfiguration : IEntityTypeConfiguration<TdSisSectionLine>
     {
          public void Configure(EntityTypeBuilder<TdSisSectionLine> builder)
          {
               builder.ToTable("td_sis_section_line");
               builder.HasKey(x => x.LineNo);
               // //builder.HasOne(x => x.TdSisSectionMaster).WithOne(p=>));
               // builder.OwnsOne(x => x.SectionId);
          }
     }
}