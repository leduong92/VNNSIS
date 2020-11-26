using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.Entities.SqlEntities;
using VNNSIS.Core.Interfaces;

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
               return await _uow.SqlRepository<MenuMasterTraining>().ListAllAsync();
          }
     }
}