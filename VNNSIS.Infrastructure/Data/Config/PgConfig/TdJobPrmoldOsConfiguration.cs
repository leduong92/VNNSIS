using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config.PgConfig
{
     public class TdJobPrmoldOsConfiguration : IEntityTypeConfiguration<TdJobPrmoldOs>
     {
          public void Configure(EntityTypeBuilder<TdJobPrmoldOs> builder)
          {
               builder.ToTable("td_job_prmold_os");
               builder.HasKey(x => x.JobOrderNo);
          }
     }
}