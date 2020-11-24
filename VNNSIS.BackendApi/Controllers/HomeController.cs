using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Interfaces;

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
               var section = await _uow.PgRepository<TmPostMachineOs>().ListAllAsync();
               return Ok(section);
          }

          [HttpGet("{line}")]
          public async Task<ActionResult<List<TmPostMachineOs>>> GetMachineByLine(string line)
          {
               var result = await _uow.PgRepository<TmPostMachineOs>().GetByIdAsync(line);
               return Ok(result);
          }
     }
}