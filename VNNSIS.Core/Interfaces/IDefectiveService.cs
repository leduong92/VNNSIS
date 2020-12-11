using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.ViewModels;

namespace VNNSIS.Core.Interfaces
{
     public interface IDefectiveService
     {
          Task<List<InforProgressVm>> GetDataByJob(string job);
     }
}