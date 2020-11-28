
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using VNNSIS.Core.Interfaces;
using VNNSIS.Core.ViewModels;
using VNNSIS.Infrastructure.EF;


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
               //var a = _sqlContext.Database.ex
               //PG
               var test = await _pgContext.TmPostMachineOs.FromSqlInterpolated($"Select * from tm_postmachine_os where line_no = {line}").ToListAsync();
               //var aaa = await _pgContext.Database.ExecuteSqlCommand("INSERT");
               //SQL
               var tes1t = await _sqlContext.MenuMasterTrainings.FromSqlInterpolated($"Select * from MenuMasterTraining").ToListAsync();

               var query = from a in _pgContext.TmPostMachineOs
                           join b in _pgContext.TdJobPrmoldOs on a.LineNo equals b.LineNo into ab
                           from x in ab.DefaultIfEmpty()
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