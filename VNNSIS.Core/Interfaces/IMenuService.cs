using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Entities.SqlEntities;
using VNNSIS.Core.ViewModels;

namespace VNNSIS.Core.Interfaces
{
     public interface IMenuService : IMenuRepository
     {
          Task<IReadOnlyList<MenuMasterTraining>> GetMenuMaster();
          Task<IReadOnlyList<MenuMasterTraining>> GetMenuByRole(string role);
          Task<List<TdSisSectionMaster>> GetSection();
          Task<List<TdSisSectionLine>> GetLineBySection(string section);
          Task<List<TdSisErrorMenu>> GetErrorMenu();
     }
}

