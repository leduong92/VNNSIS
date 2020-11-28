using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config.PgConfig
{
     public class TdJobProductOsLogConfiguration : IEntityTypeConfiguration<TdJobProductOsLog>
     {
          public void Configure(EntityTypeBuilder<TdJobProductOsLog> builder)
          {
               builder.ToTable("td_job_product_os_log");
               builder.HasKey(x => x.EntryDate);
          }
     }
}