using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.PgConfig
{
     public class SiProErrorMasterConfiguration : IEntityTypeConfiguration<SiProErrorMaster>
     {
          public void Configure(EntityTypeBuilder<SiProErrorMaster> builder)
          {
               builder.ToTable("si_pro_error_master");
               builder.HasKey(x => x.ErrorId);
               // builder.Property(x => x.ErrorId).IsRequired().HasMaxLength(10);
               // builder.Property(x => x.EntryDate).HasMaxLength(8);
               // builder.Property(x => x.EntryTime).HasMaxLength(6);
               // builder.Property(x => x.EntryUser).HasMaxLength(8);
               // builder.Property(x => x.ErrorName).HasMaxLength(255);
               // builder.Property(x => x.ErrorNameEn).HasMaxLength(255);
               // builder.Property(x => x.ErrorNameJp).HasMaxLength(255);
               // builder.Property(x => x.Status).HasMaxLength(1);
               // builder.Property(x => x.Location).HasMaxLength(5);
          }
     }
}