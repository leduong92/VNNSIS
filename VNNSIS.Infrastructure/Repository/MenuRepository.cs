using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Data;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.ViewModels;
using VNNSIS.Infrastructure.EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace VNNSIS.Infrastructure.Repository
{
     public class MenuRepository : IMenuRepository
     {
          private readonly SqlDbContext _sqlContext;
          private readonly PgDbContext _pgContext;
          public MenuRepository(SqlDbContext sqlContext, PgDbContext pgContext)
          {
               _sqlContext = sqlContext;
               _pgContext = pgContext;
          }

          public async Task<List<UserMachineVm>> GetUserVm(string line)
          {
               var query = from a in _pgContext.TmPostMachineOs
                           join b in _pgContext.TdJobPrmoldOs on a.LineNo equals b.LineNo
                           where a.LineNo == line
                           select new { a };
               var data = await query.OrderBy(x => x.a.PressNo).Select(x => new UserMachineVm()
               {
                    LineNo = x.a.LineNo,
                    PressNo = x.a.PressNo,

               }).ToListAsync();


               return data;
          }
     }
}