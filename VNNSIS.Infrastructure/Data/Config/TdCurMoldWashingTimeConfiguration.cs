using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config
{
     public class TdCurMoldWashingTimeConfiguration : IEntityTypeConfiguration<TdCurMoldWashingTime>
     {
          public void Configure(EntityTypeBuilder<TdCurMoldWashingTime> builder)
          {
               builder.ToTable("td_cur_mold_washing_time");
               builder.HasKey(x => x.LineNo);
          }
     }
}