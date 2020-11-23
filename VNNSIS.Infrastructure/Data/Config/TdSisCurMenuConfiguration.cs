using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config
{
     public class TdSisCurMenuConfiguration : IEntityTypeConfiguration<TdSisCurMenu>
     {
          public void Configure(EntityTypeBuilder<TdSisCurMenu> builder)
          {
               builder.ToTable("td_sis_cur_menu");
               builder.HasKey(x => x.MenuId);
          }
     }
}