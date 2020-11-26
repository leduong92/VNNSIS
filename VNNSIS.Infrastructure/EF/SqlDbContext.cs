using System.Reflection;
using Microsoft.EntityFrameworkCore;
using VNNSIS.Core.Entities.SqlEntities;

namespace VNNSIS.Infrastructure.EF
{
     public class SqlDbContext : DbContext
     {
          public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
          {
          }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
               base.OnModelCreating(modelBuilder);
               modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
          }

          // public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
          // public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
          // public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
          // public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
          // public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
          // public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
          // public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
          public virtual DbSet<MenuMasterTraining> MenuMasterTrainings { get; set; }
          public virtual DbSet<SisProErrorRecord> SisProErrorRecords { get; set; }

     }
}