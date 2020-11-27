using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VNNSIS.Core.Entities.SqlEntities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Infrastructure.Data;
using VNNSIS.Infrastructure.EF;

namespace VNNSIS.Infrastructure.Services
{
     public class MenuService : GenericRepository<MenuMasterTraining>, IMenuService
     {
          private readonly SqlDbContext _sqlContext;
          private readonly PgDbContext _pgContext;
          public MenuService(SqlDbContext sqlDbContext, PgDbContext pgDbContext) : base(sqlDbContext)
          {
               _sqlContext = sqlDbContext;
               _pgContext = pgDbContext;
          }

          public async Task<IReadOnlyList<MenuMasterTraining>> GetMenuMaster()
          {
               return await _sqlContext.MenuMasterTrainings.ToListAsync();
          }
          // public async Task<IReadOnlyList<MenuMasterTraining>> GetMenuMaster()
          // {

          //     // return await _uow.SqlRepository<MenuMasterTraining>().ListAllAsync();
          // }
     }
}