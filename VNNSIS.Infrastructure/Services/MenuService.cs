using System;
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
               var data = await _uow.SqlRepository<MenuMasterTraining>().ListAllAsync();
               return data;
          }
          public async Task<IReadOnlyList<MenuMasterTraining>> GetMenuByRole(string role)
          {
               var spec = new SelectMenuByStringId(role);
               var data = await _uow.SqlRepository<MenuMasterTraining>().ListAsync(spec);
               return data;
          }
          public async Task<List<TdSisErrorMenu>> GetErrorMenu()
          {
               var lstErr = await _uow.PgRepository<TdSisErrorMenu>().ListAllAsync();
               return lstErr;
          }
          public async Task<List<TdSisSectionMaster>> GetSection()
          {
               var section = await _uow.PgRepository<TdSisSectionMaster>().ListAllAsync();
               return section;
          }

          public async Task<List<TdSisSectionLine>> GetLineBySection(string section)
          {
               var spec = new SelectLineBySection(section);
               var data = await _uow.PgRepository<TdSisSectionLine>().ListAsync(spec);
               return data;
          }
          public async Task<List<TmPostMachineOs>> GetMachineByLine(string line)
          {
               var result = await _menuRepo.GetMachineByLine(line);
               return result;
          }

          public async Task<int> UpdTmPostMachineOs(UpdateTmMachineRequest request)
          {
               var result = await _menuRepo.UpdTmPostMachineOs(request);
               return result;
          }

          public async Task<List<UserMachineVm>> GetUserVm(string line)
          {
               var result = await _menuRepo.GetUserVm(line);
               return result;
          }
     }
}