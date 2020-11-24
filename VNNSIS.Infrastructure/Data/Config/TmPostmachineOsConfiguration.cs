using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config
{
     public class TmPostmachineOsConfiguration : IEntityTypeConfiguration<tm_postmachine_os>
     {
          public void Configure(EntityTypeBuilder<tm_postmachine_os> builder)
          {
               builder.ToTable("tm_postmachine_os");
               builder.HasKey(x => new { x.LineNo, x.PressNo });
          }
     }
}