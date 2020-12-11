using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.ViewModels;
namespace VNNSIS.Core.Interfaces
{
     public interface IDefectiveRepository
     {
          Task<List<InforProgressVm>> GetDataByJob(string job);
          Task<List<ErrorListVm>> GetErrListByOperationCode(string jobOrderNo, string operationCode);

     }
}