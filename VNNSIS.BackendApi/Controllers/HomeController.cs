using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.Specification;
using System.Linq;
using VNNSIS.BackendApi.Dtos;
using AutoMapper;
using VNNSIS.Core.Entities.SqlEntities;

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

     }
}