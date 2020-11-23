using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config
{
     public class TdSisErrorMenuConfiguration : IEntityTypeConfiguration<TdSisErrorMenu>
     {
          public void Configure(EntityTypeBuilder<TdSisErrorMenu> builder)
          {
               builder.ToTable("td_sis_error_menu");
               builder.HasKey(x => x.ErrorId);
          }
     }
}