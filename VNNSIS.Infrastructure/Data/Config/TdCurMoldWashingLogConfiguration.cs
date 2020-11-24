using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config
{
     public class TdCurMoldWashingLogConfiguration : IEntityTypeConfiguration<TdCurMoldWashingLog>
     {
          public void Configure(EntityTypeBuilder<TdCurMoldWashingLog> builder)
          {
               builder.ToTable("td_cur_mold_washing_log");
               builder.HasKey(x => x.Id);
               // builder.HasKey(x => x.MoldUp);
               // builder.HasKey(x => x.MoldDown);
          }
     }
}