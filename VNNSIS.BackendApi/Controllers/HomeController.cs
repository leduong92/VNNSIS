using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.Entities.SqlEntities;
using VNNSIS.Core.ViewModels;

namespace VNNSIS.BackendApi.Controllers
{
     public class HomeController : BaseApiController
     {
          private readonly IMenuService _menuService;
          public HomeController(IMenuService menuService)
          {
               _menuService = menuService;
          }
          [HttpGet]
          public async Task<ActionResult<IReadOnlyList<MenuMasterTraining>>> GetMenu()
          {
               var data = await _menuService.GetMenuMaster();
               return Ok(data);
          }
          [HttpGet("role/{role}")]
          public async Task<ActionResult<IReadOnlyList<MenuMasterTraining>>> GetMenuByRole(string role)
          {
               var data = await _menuService.GetMenuByRole(role);

               return Ok(data);
          }
          [HttpGet("{line}")]
          public async Task<ActionResult<List<UserMachineVm>>> Get(string line)
          {
               var data = await _menuService.GetUserVm(line);

               return Ok(data);
          }
          [HttpPost]
          public async Task<ActionResult> Update([FromQuery] UpdateTmMachineRequest request)
          {
               if (!ModelState.IsValid)
               {
                    return BadRequest(ModelState);
               }
               var affectedResult = await _menuService.UpdTmPostMachineOs(request);
               if (affectedResult == 0)
               {
                    return BadRequest(0);
               }
               return Ok();
          }

     }
}