using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config
{
     public class TdCurMoldMasterConfiguration : IEntityTypeConfiguration<TdCurMoldMaster>
     {
          public void Configure(EntityTypeBuilder<TdCurMoldMaster> builder)
          {
               builder.ToTable("td_cur_mold_master");
               builder.HasKey(x => x.MoldUp);
               builder.HasKey(x => x.MoldDown);
          }
     }
}