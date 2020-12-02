
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

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
               //var test = await _pgContext.TmPostMachineOs.FromSqlInterpolated($"Select * from tm_postmachine_os where line_no = {line}").ToListAsync();
               //var aaaa = _pgContext.UserMachineVms.FromSqlRaw("");
               //SQL 
               //var tes1t = await _sqlContext.MenuMasterTrainings.FromSqlInterpolated($"Select * from MenuMasterTraining").ToListAsync();
               // "where a.line_no = '{0}' and b.status = '1' and a.press_no like 'D%' order by a.press_no", lineNo);
               var query = from a in _pgContext.TmPostMachineOs
                           join b in _pgContext.TdJobPrmoldOs on new { a.LineNo, a.PressNo } equals new { b.LineNo, b.PressNo } into ab
                           //on a.LineNo equals b.LineNo into ab
                           from x in ab.DefaultIfEmpty()
                           join c in _pgContext.TdSisCurMenu on a.Status.ToString() equals c.MenuId into cc
                           from y in cc.DefaultIfEmpty()
                           where a.LineNo == line && x.Status == 1 && a.PressNo.StartsWith("D")
                           select new
                           {
                                a.LineNo,
                                a.PressNo,
                                a.PlcM,
                                a.PlcM1,
                                a.PlcM2,
                                a.Ip,
                                a.Status,
                                a.MoldType,
                                a.TrimType,
                                x.StartDate,
                                x.StartTime,
                                x.StartUser,
                                x.StartDate01,
                                x.StartTime01,
                                x.StartUser01,
                                y.MenuName
                           };
               var data = await query.OrderBy(x => x.PressNo).Select(x => new UserMachineVm()
               {
                    LineNo = x.LineNo,
                    PressNo = x.PressNo,
                    PlcM = x.PlcM,
                    PlcM1 = x.PlcM1,
                    PlcM2 = x.PlcM2,
                    Ip = x.Ip,
                    Status = x.Status,
                    MoldType = x.MoldType,
                    TrimType = x.TrimType,
                    StartDate = x.StartDate,
                    StartTime = x.StartTime,
                    StartUser = x.StartUser,
                    StartDate01 = x.StartDate01,
                    StartTime01 = x.StartTime01,
                    StartUser01 = x.StartUser01,
                    MenuName = x.MenuName

               }).ToListAsync();


               return data;
          }
     }
}