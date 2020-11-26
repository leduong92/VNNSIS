

using Microsoft.AspNetCore.Mvc;
using VNNSIS.BackendApi.Errors;

namespace VNNSIS.BackendApi.Controllers
{
     [Route("errors/{code}")]
     [ApiExplorerSettings(IgnoreApi = true)]
     public class ErrorController : BaseApiController
     {
          public IActionResult Error(int code)
          {
               return new ObjectResult(new ApiResponse(code));
          }
     }
}