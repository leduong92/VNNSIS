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
          private readonly IUnitOfWork _uow;
          private readonly IMapper _mapper;
          public HomeController(IUnitOfWork uow, IMapper mapper)
          {
               _uow = uow;
               _mapper = mapper;
          }

          [HttpGet("menu")]
          public async Task<ActionResult<IReadOnlyList<MenuMasterTraining>>> GetMenu()
          {
               var data = await _uow.SqlRepository<MenuMasterTraining>().ListAllAsync();
               return Ok(data);
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