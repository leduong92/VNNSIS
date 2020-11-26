using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.PgConfig
{
     public class TdCurProgressCheckConfiguration : IEntityTypeConfiguration<TdCurProgressCheck>
     {
          public void Configure(EntityTypeBuilder<TdCurProgressCheck> builder)
          {
               builder.ToTable("td_cur_progress_check");
               builder.HasKey(x => x.JobOrderNo);
               builder.HasKey(x => x.OperationCode);
          }
     }
}