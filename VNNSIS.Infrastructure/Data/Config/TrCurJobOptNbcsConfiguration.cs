using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config
{
     public class TrCurJobOptNbcsConfiguration : IEntityTypeConfiguration<TrCurJobOptNbcs>
     {
          public void Configure(EntityTypeBuilder<TrCurJobOptNbcs> builder)
          {
               builder.ToTable("tr_cur_job_opt_nbcs");
               builder.HasKey(x => x.JobOrderNo);
          }
     }
}