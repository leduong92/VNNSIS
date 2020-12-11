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
     }
}