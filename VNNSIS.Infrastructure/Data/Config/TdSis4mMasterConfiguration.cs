using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.Data.Config
{
     public class TdSis4mMasterConfiguration : IEntityTypeConfiguration<TdSis4mMaster>
     {
          public void Configure(EntityTypeBuilder<TdSis4mMaster> builder)
          {
               builder.ToTable("td_sis_4m_master");
               builder.HasKey(x => x.Id);
          }
     }
}