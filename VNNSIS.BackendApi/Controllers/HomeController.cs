using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNNSIS.Core.Entities.PgEntities;
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

          [HttpGet("menu")]
          public async Task<ActionResult<IReadOnlyList<MenuMasterTraining>>> GetMenu()
          {

               var data = await _menuService.GetMenuMaster();

               return Ok(data);
          }
          [HttpGet("{role}")]
          public async Task<ActionResult<IReadOnlyList<MenuMasterTraining>>> GetMenuByRole(string role)
          {
               var data = await _menuService.GetMenuByRole(role);

               return Ok(data);
          }
          [HttpGet("{line}")]
          public async Task<ActionResult<List<UserMachineVm>>> Get(string line)
          {
               var data = await _menuService.GetUserInMachineByLine(line);

               return Ok(data);
          }

     }
}