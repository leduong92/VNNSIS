using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.Specification;
using System.Linq;
using VNNSIS.BackendApi.Dtos;
using AutoMapper;

namespace VNNSIS.BackendApi.Controllers
{
     public class HomeController : BaseApiController
     {
          private readonly IUnitOfWork _uow;
          private readonly IMapper _mapper;
          public HomeController(IUnitOfWork uow, IMapper mapper)
          {
               _uow = uow;
               _mapper = mapper;
          }

          [HttpGet]
          public async Task<ActionResult<IReadOnlyList<TmPostMachineOsReturnDto>>> GetSection()
          {
               var section = await _uow.PgRepository<TmPostMachineOs>().ListAsync(new OrderByTmPostMachineOsWithLineNo());

               var data = _mapper.Map<IReadOnlyList<TmPostMachineOs>, IReadOnlyList<TmPostMachineOsReturnDto>>(section);
               return Ok(data);
          }

          [HttpGet("{line}")]
          public async Task<ActionResult<IReadOnlyList<TmPostMachineOsReturnDto>>> GetMachineByLine(string line)
          {
               var result = await _uow.PgRepository<TmPostMachineOs>().ListAsync(new OrderByTmPostMachineOsWithLineNo(line));

               var data = _mapper.Map<IReadOnlyList<TmPostMachineOs>, IReadOnlyList<TmPostMachineOsReturnDto>>(result);
               return Ok(data);
          }
     }
}