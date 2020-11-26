using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.PgConfig
{
     public class TrCurJobNbcsConfiguration : IEntityTypeConfiguration<TrCurJobNbcs>
     {
          public void Configure(EntityTypeBuilder<TrCurJobNbcs> builder)
          {
               builder.ToTable("tr_cur_job_nbcs");
               builder.HasKey(x => x.JobOrderNo);
          }
     }
}