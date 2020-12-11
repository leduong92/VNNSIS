using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.ViewModels;
using VNNSIS.Infrastructure.EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace VNNSIS.Infrastructure.Repository
{
     public class DefectiveRepository : IDefectiveRepository
     {
          private readonly SqlDbContext _sqlContext;
          private readonly PgDbContext _pgContext;
          public DefectiveRepository(SqlDbContext sqlContext, PgDbContext pgContext)
          {
               _sqlContext = sqlContext;
               _pgContext = pgContext;
          }
          public async Task<List<InforProgressVm>> GetDataByJob(string jobOrderNo)
          {
               var query = from a in _pgContext.TrCurJobNbcs
                           join b in _pgContext.TdCurProgressMaster on a.FinishedGoodsCode equals b.FinishedGoodsCode
                           where a.JobOrderNo == jobOrderNo
                           select new { a.JobOrderNo, a.OrderType, a.FinishedGoodsCode, b.OperationCode, b.OperationName, b.OperationSequence, a.LineNo, a.PressNo, a.MaterialMark1, a.Rotation, a.CuringQty, a.CavityQty, a.CuringDate };

               var result = await query.OrderBy(x => x.OperationSequence).Select(x => new InforProgressVm()
               {
                    job_order_no = x.JobOrderNo,
                    lot_no = x.OrderType,
                    finished_goods_code = x.FinishedGoodsCode,
                    operation_code = x.OperationCode,
                    operation_name = x.OperationName,
                    operation_sequence = x.OperationSequence,
                    line_no = string.Concat(x.LineNo + "/" + x.PressNo),
                    material_mark1 = x.MaterialMark1,
                    rotation = x.Rotation,
                    curing_qty = x.CuringQty,
                    curing_date = x.CuringDate.ToString(),
                    cavity_qty = x.CavityQty

               }).ToListAsync();
               return result;
          }

          public async Task<List<ErrorListVm>> GetErrListByOperationCode(string jobOrderNo, string operationCode)
          {
               var query = from a in _pgContext.TdCurProgress
                           join b in _pgContext.SiProErrorDetail on a.OperationSequence equals b.ProgressOperationSeq into ab
                           from x in ab.DefaultIfEmpty()
                           join c in _pgContext.SiProErrorMaster on x.ErrorId equals c.ErrorId into xc
                           from y in xc.DefaultIfEmpty()
                           join d in _pgContext.TdCurProgressCheck on a.OperationCode equals d.OperationCode into yd
                           from z in yd.DefaultIfEmpty()
                           where z.JobOrderNo == jobOrderNo && a.OperationCode == operationCode && x.Location.Contains("OS1") && x.Department.Contains("60") && x.ProgramId.Contains("ID")
                           select new { a, x.ErrorId, x.Department, x.Area, x.ProgramId, y.ErrorName, y.ErrorNameJp, y.ErrorNameEn, z.StartDate, z.EndDate, z.MachineNo };
               var data = await query.OrderBy(x => x.ErrorId).Select(o => new ErrorListVm()
               {
                    error_id = o.ErrorId,
                    department = o.Department,
                    area = o.Area,
                    program_id = o.ProgramId,
                    error_name = o.ErrorName,
                    error_name_en = o.ErrorNameEn,
                    error_name_jp = o.ErrorNameJp,
                    start_date = o.StartDate,
                    end_date = o.EndDate,
                    machine_no = o.MachineNo,
                    operation_code = o.a.OperationCode,
                    operation_name = o.a.OperationName,
                    operation_sequence = o.a.OperationSequence
               }).ToListAsync();
               return data;
          }
     }
}