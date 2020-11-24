using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Infrastructure.EF;

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
          public async Task<ActionResult<List<TdSisCurMenu>>> GetSection()
          {
               var section = await _uow.PgRepository<TdSisCurMenu>().ListAllAsync();
               return Ok(section);
          }

          [HttpGet("{line}")]
          public async Task<ActionResult<List<TmPostmachineOs>>> GetMachineByLine(string line)
          {
               var result = await _uow.PgRepository<TmPostmachineOs>().GetByIdAsync(line);
               return Ok(result);
          }
     }
}