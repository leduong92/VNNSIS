using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.Entities.SqlEntities;
using VNNSIS.Core.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace VNNSIS.BackendApi.Controllers
{
     public class DefectiveController : BaseApiController
     {
          private readonly IDefectiveService _service;
          public DefectiveController(IDefectiveService service)
          {
               _service = service;
          }
          [HttpGet("{job}")]
          public async Task<ActionResult> GetDataByJobNo(string job)
          {
               var result = await _service.GetDataByJob(job);
               return Ok(result);
          }
          [HttpGet("featured/{job}/{operationcode}")]
          [AllowAnonymous]
          public async Task<ActionResult> GetDataByOperationCode(string job, string operationcode)
          {
               var result = await _service.GetErrListByOperationCode(job, operationcode);
               return Ok(result);
          }
     }
}