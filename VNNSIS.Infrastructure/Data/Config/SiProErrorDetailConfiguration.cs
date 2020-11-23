using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config
{
     public class SiProErrorDetailConfiguration : IEntityTypeConfiguration<SiProErrorDetail>
     {
          public void Configure(EntityTypeBuilder<SiProErrorDetail> builder)
          {
               builder.ToTable("si_pro_error_detail");
               builder.HasKey(x => x.ProgressOperationSeq);
               // builder.HasKey(x => x.ErrorId);
               // builder.HasKey(x => x.Location);
               // builder.HasKey(x => x.Department);
               //builder.HasKey(x => x.ProgramId);
               // builder.Property(x => x.ProgressOperationSeq).IsRequired();
               // builder.Property(x => x.ErrorId).IsRequired().HasMaxLength(10);
               // builder.Property(x => x.EntryDate).HasMaxLength(8);
               // builder.Property(x => x.EntryTime).HasMaxLength(6);
               // builder.Property(x => x.EntryUser).HasMaxLength(8);
               // builder.Property(x => x.Location).HasMaxLength(5).IsRequired();
               // builder.Property(x => x.Status).HasMaxLength(1);
               // builder.Property(x => x.Department).HasMaxLength(10).IsRequired();
               // builder.Property(x => x.Area).HasMaxLength(10);
               // builder.Property(x => x.ProgramId).HasMaxLength(10).IsRequired();
               // builder.Property(x => x.ErrorDeptId).HasMaxLength(10);
          }
     }
}