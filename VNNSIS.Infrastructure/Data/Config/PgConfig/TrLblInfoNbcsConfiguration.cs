using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.PgConfig
{
     public class TrLblInfoNbcsConfiguration : IEntityTypeConfiguration<TrLblInfoNbcs>
     {
          public void Configure(EntityTypeBuilder<TrLblInfoNbcs> builder)
          {
               builder.ToTable("tr_lbl_info_nbcs");
               builder.HasKey(x => x.JobOrderNo);
               builder.HasKey(x => x.MpsNo);
          }
     }
}