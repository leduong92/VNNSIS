using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.PgConfig
{
     public class TrLblOptNbcsConfiguration : IEntityTypeConfiguration<TrLblOptNbcs>
     {
          public void Configure(EntityTypeBuilder<TrLblOptNbcs> builder)
          {
               builder.ToTable("tr_lbl_opt_nbcs");
               builder.HasKey(x => x.JobOrderNo);
               builder.HasKey(x => x.MpsNo);
          }
     }
}