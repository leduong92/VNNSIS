using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.PgConfig
{
     public class TdCurProgressMasterConfiguration : IEntityTypeConfiguration<TdCurProgressMaster>
     {
          public void Configure(EntityTypeBuilder<TdCurProgressMaster> builder)
          {
               builder.ToTable("td_cur_progress_master");
               builder.HasKey(x => x.FinishedGoodsCode);
               builder.HasKey(x => x.OperationCode);
          }
     }
}