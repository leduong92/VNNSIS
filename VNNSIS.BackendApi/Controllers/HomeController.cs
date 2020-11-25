using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.Specification;
using System.Linq;

namespace VNNSIS.BackendApi.Controllers
{
     public class HomeController : BaseApiController
     {
          private readonly IUnitOfWork _uow;
          public HomeController(IUnitOfWork uow)
          {
               _uow = uow;
          }

          [HttpGet]
          public async Task<ActionResult<List<TmPostMachineOs>>> GetSection()
          {
               //var section = await _uow.PgRepository<TmPostMachineOs>().ListAllAsync();
               var spec = new OrderByTmPostMachineOsWithLineNo();
               var section = await _uow.PgRepository<TmPostMachineOs>().ListAsync(spec);
               return Ok(section);
          }

          [HttpGet("{line}")]
          public async Task<ActionResult<List<TmPostMachineOs>>> GetMachineByLine(string line)
          {
               var spec = new OrderByTmPostMachineOsWithLineNo();
               var result = await _uow.PgRepository<TmPostMachineOs>().GetEntityWithSpec(spec);
               return Ok(result);
          }
     }
}