using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.Entities.SqlEntities;
using VNNSIS.Core.ViewModels;

namespace VNNSIS.BackendApi.Controllers
{
     public class DefectiveController : BaseApiController
     {
          private readonly IDefectiveService _service;
          public DefectiveController(IDefectiveService service)
          {
               _service = service;
          }
          [HttpGet]
          public async Task<ActionResult> GetData()
          {
               var result = await _service.GetDataByJob("AA020082-010");
               return Ok(result);
          }
     }
}