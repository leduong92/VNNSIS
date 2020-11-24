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
          public async Task<ActionResult<List<tm_postmachine_os>>> GetSection()
          {
               var section = await _uow.PgRepository<tm_postmachine_os>().ListAllAsync();
               return Ok(section);
          }

          [HttpGet("{line}")]
          public async Task<ActionResult<List<tm_postmachine_os>>> GetMachineByLine(string line)
          {
               var result = await _uow.PgRepository<tm_postmachine_os>().GetByIdAsync(line);
               return Ok(result);
          }
     }
}