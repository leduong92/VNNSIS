using Microsoft.EntityFrameworkCore;

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
          }
     }
}