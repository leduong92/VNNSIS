using Microsoft.EntityFrameworkCore;
using VNNSIS.Core.Entities.SqlEntities;

namespace VNNSIS.Infrastructure.Data.Config.SqlConfig
{
     public class MenuMasterTrainingConfiguration : IEntityTypeConfiguration<MenuMasterTraining>
     {
          public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MenuMasterTraining> builder)
          {
               builder.ToTable("MenuMasterTraining");
               builder.HasKey(x => x.MenuIdentity);
          }
     }
}