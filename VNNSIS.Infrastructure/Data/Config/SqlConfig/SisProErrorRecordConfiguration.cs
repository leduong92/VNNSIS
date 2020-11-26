using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.SqlEntities;

namespace VNNSIS.Infrastructure.Data.Config.SqlConfig
{
     public class SisProErrorRecordConfiguration : IEntityTypeConfiguration<SisProErrorRecord>
     {
          public void Configure(EntityTypeBuilder<SisProErrorRecord> builder)
          {
               builder.ToTable("SisProErrorRecord");
               builder.HasKey(x => x.JobOrderNo);
          }
     }
}