using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.PgConfig
{
     public class TdCurProgressConfiguration : IEntityTypeConfiguration<TdCurProgress>
     {
          public void Configure(EntityTypeBuilder<TdCurProgress> builder)
          {
               builder.ToTable("td_cur_progress");
               builder.HasKey(x => x.OperationSequence);
               builder.HasKey(x => x.OperationCode);
          }
     }
}