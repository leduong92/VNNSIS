using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.Entities.SqlEntities;
using VNNSIS.Core.ViewModels;

namespace VNNSIS.Core.Interfaces
{
     public interface IMenuService
     {
          Task<IReadOnlyList<MenuMasterTraining>> GetMenuMaster();
          Task<IReadOnlyList<TmPostMachineOs>> GetMenu();

          Task<List<UserMachineVm>> GetUserMachineByLine(string line);

     }
}