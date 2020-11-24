using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config
{
     public class TdSisCurRecordConfiguration : IEntityTypeConfiguration<TdSisCurRecord>
     {
          public void Configure(EntityTypeBuilder<TdSisCurRecord> builder)
          {
               builder.ToTable("td_sis_cur_record");
               builder.HasKey(x => x.Id);
          }
     }
}