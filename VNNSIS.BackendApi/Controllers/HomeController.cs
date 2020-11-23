using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Infrastructure.EF;

namespace VNNSIS.BackendApi.Controllers
{
     public class HomeController : BaseApiController
     {
          private readonly PgDbContext _context;

          public HomeController(PgDbContext context)
          {
               _context = context;
          }

          [HttpGet]
          public async Task<ActionResult<List<TdSisCurMenu>>> GetSection()
          {
               var section = await _context.TdSisCurMenu.Take(200).ToListAsync();
               return Ok(section);
          }

          [HttpGet("{line}}")]
          public async Task<ActionResult<List<TmPostmachineOs>>> GetMachineByLine(string line)
          {
               var result = await _context.TmPostmachineOs.Where(x => x.LineNo == line).ToListAsync();
               return Ok(result);
          }
     }
}