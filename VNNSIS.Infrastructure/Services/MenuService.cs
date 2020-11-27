using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VNNSIS.Core.Entities;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Entities.SqlEntities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.Specification;
using VNNSIS.Infrastructure.Data;
using VNNSIS.Infrastructure.EF;

namespace VNNSIS.Infrastructure.Services
{
     public class MenuService : IMenuService
     {
          private readonly IUnitOfWork _uow;
          public MenuService(IUnitOfWork uow)
          {
               _uow = uow;
          }

          public async Task<IReadOnlyList<MenuMasterTraining>> GetMenuMaster()
          {
               var data = await _uow.SqlRepository<MenuMasterTraining>().ListAllAsync();
               return data;
          }

          public async Task<IReadOnlyList<TmPostMachineOs>> GetMenu()
          {
               var data = await _uow.PgRepository<TmPostMachineOs>().ListAllAsync();
               return data;
          }
     }
}