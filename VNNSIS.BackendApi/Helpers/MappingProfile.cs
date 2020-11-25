using AutoMapper;
using VNNSIS.BackendApi.Dtos;
using VNNSIS.Core.Entities.PgEntities;

namespace VNNSIS.BackendApi.Helpers
{
     public class MappingProfile : Profile
     {
          public MappingProfile()
          {
               CreateMap<TmPostMachineOs, TmPostMachineOsReturnDto>();
          }
     }
}