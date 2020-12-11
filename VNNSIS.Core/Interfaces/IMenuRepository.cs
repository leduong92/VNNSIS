using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.Entities.PgEntities;
using VNNSIS.Core.ViewModels;

namespace VNNSIS.Core.Interfaces
{
     public interface IMenuRepository
     {
          Task<List<UserMachineVm>> GetUserVm(string line);
          Task<List<TmPostMachineOs>> GetMachineByLine(string line);
          Task<int> UpdTmPostMachineOs(UpdateTmMachineRequest request);
     }
}