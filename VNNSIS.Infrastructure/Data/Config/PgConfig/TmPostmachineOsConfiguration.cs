using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.PgConfig
{
     public class TmPostmachineOsConfiguration : IEntityTypeConfiguration<TmPostMachineOs>
     {
          public void Configure(EntityTypeBuilder<TmPostMachineOs> builder)
          {
               builder.ToTable("tm_postmachine_os");
               builder.HasKey(x => new { x.LineNo, x.PressNo });
          }
     }
}