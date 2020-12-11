using System.Collections.Generic;
using System.Threading.Tasks;
using VNNSIS.Core.Interfaces;
using VNNSIS.Core.ViewModels;

namespace VNNSIS.Infrastructure.Services
{
     public class DefectiveService : IDefectiveService
     {
          private readonly IDefectiveRepository _defectiveRepo;
          private readonly IUnitOfWork _uow;
          public DefectiveService(IUnitOfWork uow, IDefectiveRepository defectiveRepo)
          {
               _uow = uow;
               _defectiveRepo = defectiveRepo;
          }

          public Task<List<InforProgressVm>> GetDataByJob(string job)
          {
               throw new System.NotImplementedException();
          }
     }
}