using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.PgConfig
{
     public class TdCurMoldLogConfiguration : IEntityTypeConfiguration<TdCurMoldLog>
     {
          public void Configure(EntityTypeBuilder<TdCurMoldLog> builder)
          {
               builder.ToTable("td_cur_mold_log");
               builder.HasKey(x => x.MoldUp);
               builder.HasKey(x => x.MoldDown);
               builder.HasKey(x => x.SetupDate);
               builder.HasKey(x => x.SetupTime);
               builder.HasKey(x => x.StartDate);
               builder.HasKey(x => x.StartTime);
               builder.HasKey(x => x.MoldJob);
          }
     }
}