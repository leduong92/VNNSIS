using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Entities.SqlEntities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.ViewModels;

namespace VNNSIS.Infrastructure.Services
{
     public class MenuService : IMenuService
     {
          private readonly IMenuRepository _menuRepo;
          private readonly IUnitOfWork _uow;
          public MenuService(IUnitOfWork uow, IMenuRepository menuRepo)
          {
               _uow = uow;
               _menuRepo = menuRepo;
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

          public async Task<List<UserMachineVm>> GetUserMachineByLine(string line)
          {
               var result = await _menuRepo.GetUserVm(line);
               return result;
          }
     }
}