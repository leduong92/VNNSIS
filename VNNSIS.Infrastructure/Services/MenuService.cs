using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Entities.SqlEntities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.ViewModels;
using VNNSIS.Infrastructure.EF;
using System.Linq;

namespace VNNSIS.Infrastructure.Services
{
     public class MenuService : IMenuService
     {
          private readonly PgDbContext _pgContext;
          private readonly SqlDbContext _sqlContext;
          public MenuService(PgDbContext pgContext, SqlDbContext sqlContext)
          {
               _pgContext = pgContext;
               _sqlContext = sqlContext;
          }
          public async Task<IReadOnlyList<MenuMasterTraining>> GetMenuMaster()
          {
               var data = await _sqlContext.MenuMasterTrainings.ToListAsync();
               return data;
          }
          public async Task<IReadOnlyList<MenuMasterTraining>> GetMenuByRole(string role)
          {
               var query = from a in _sqlContext.MenuMasterTrainings
                           where a.UserRole == role
                           select new { a };
               var data = await query.OrderBy(x => x.a.MenuIdentity).Select(x => new MenuMasterTraining()
               {

               }).ToListAsync();
               return data;
          }
          public async Task<List<TdSisErrorMenu>> GetErrorMenu()
          {
               var data = await _pgContext.TdSisErrorMenu.ToListAsync();
               return data;
          }
          public async Task<List<TdSisSectionMaster>> GetSection()
          {
               var section = await _pgContext.TdSisSectionMaster.ToListAsync();
               return section;
          }

          public async Task<List<TdSisSectionLine>> GetLineBySection(string section)
          {
               var query = from a in _pgContext.TdSisSectionLine
                           where a.SectionId == section
                           select new { a };

               var data = await query.OrderBy(x => x.a.LineNo).Select(x => new TdSisSectionLine()
               {

               }).ToListAsync();
               return data;
          }
          public async Task<List<TmPostMachineOs>> GetMachineByLine(string line)
          {
               var data = await _pgContext.TmPostMachineOs.Where(x => x.LineNo == line && x.PressNo.StartsWith("D")).OrderBy(x => x.PressNo)
               .Select(x => new TmPostMachineOs()
               {
                    LineNo = x.LineNo,
                    PressNo = x.PressNo,
                    PlcM = x.PlcM,
                    PlcM1 = x.PlcM1,
                    PlcM2 = x.PlcM2,
                    Ip = x.Ip,
                    Status = x.Status,
                    MoldType = x.MoldType,
                    TrimType = x.TrimType
               }).ToListAsync();
               return data;
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

          public async Task<int> UpdTmPostMachineOs(UpdateTmMachineRequest request)
          {
               var data = await _pgContext.TmPostMachineOs.FindAsync(request.LineNo, request.PressNo);


               if (request.LineNo != null)
               {
                    data.Status = Convert.ToInt16(request.Value);
               }
               _pgContext.TmPostMachineOs.Update(data);
               return await _pgContext.SaveChangesAsync();
          }
     }
}