using System.Reflection;
using Microsoft.EntityFrameworkCore;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.Infrastructure.EF
{
     public class PgDbContext : DbContext
     {
          public PgDbContext(DbContextOptions<PgDbContext> options) : base(options)
          {
          }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
               base.OnModelCreating(modelBuilder);
               modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
          }
          public DbSet<SiProErrorDetail> SiProErrorDetail { get; set; }
          public DbSet<SiProErrorMaster> SiProErrorMaster { get; set; }
          public DbSet<TdCurMoldLog> TdCurMoldLog { get; set; }
          public DbSet<TdCurMoldMaster> TdCurMoldMaster { get; set; }
          public DbSet<TdCurMoldWashingLog> TdCurMoldWashingLog { get; set; }
          public DbSet<TdCurMoldWashingTime> TdCurMoldWashingTime { get; set; }
          public DbSet<TdCurProgress> TdCurProgress { get; set; }
          public DbSet<TdCurProgressCheck> TdCurProgressCheck { get; set; }
          public DbSet<TdCurProgressMaster> TdCurProgressMaster { get; set; }
          public DbSet<TdSis4mMaster> TdSis4mMaster { get; set; }
          public DbSet<TdSisCurMenu> TdSisCurMenu { get; set; }
          public DbSet<TdSisCurRecord> TdSisCurRecord { get; set; }
          public DbSet<TdSisErrorMenu> TdSisErrorMenu { get; set; }
          public DbSet<TdSisSectionLine> TdSisSectionLine { get; set; }
          public DbSet<TdSisSectionMaster> TdSisSectionMaster { get; set; }
          public DbSet<TmPostMachineOs> TmPostMachineOs { get; set; }
          public DbSet<TrCurJobNbcs> TrCurJobNbcs { get; set; }
          public DbSet<TrCurJobOptNbcs> TrCurJobOptNbcs { get; set; }
          public DbSet<TrLblInfoNbcs> TrLblInfoNbcs { get; set; }
          public DbSet<TrLblOptNbcs> TrLblOptNbcs { get; set; }

     }
}