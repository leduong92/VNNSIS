using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.Entities.SqlEntities;

namespace VNNSIS.Core.Interfaces
{
     public interface IMenuService
     {
          Task<IReadOnlyList<MenuMasterTraining>> GetMenuMaster();
     }
}