using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Entities.SqlEntities;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.Specification;
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
               var data = await _uow.SqlRepository<MenuMasterTraining>().ListAsync();
               return data;
          }

          public async Task<IReadOnlyList<MenuMasterTraining>> GetMenuByRole(string role)
          {
               var spec = new SelectMenuByStringId(role);
               var data = await _uow.SqlRepository<MenuMasterTraining>().ListAsync(spec);
               return data;
          }

          public async Task<List<UserMachineVm>> GetUserInMachineByLine(string line)
          {
               var result = await _menuRepo.GetUserVm(line);
               return result;
          }

          public Task<List<TmPostMachineOs>> GetMachineByLine(string line)
          {
               throw new System.NotImplementedException();
          }

          public Task<List<TdSisSectionMaster>> GetSection()
          {
               throw new System.NotImplementedException();
          }

          public Task<List<TdSisSectionLine>> GetLineBySection(string section)
          {
               throw new System.NotImplementedException();
          }

          public Task<List<TdSisErrorMenu>> GetErrorMenu()
          {
               throw new System.NotImplementedException();
          }
     }
}