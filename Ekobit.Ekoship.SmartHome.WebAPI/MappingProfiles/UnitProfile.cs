using AutoMapper;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.WebAPI.Models.Unit;

namespace Ekobit.Ekoship.SmartHome.WebAPI.MappingProfiles
{
    public class UnitProfile : Profile
    {
        public UnitProfile()
        {
            CreateMap<Unit, UnitDetails>();

            CreateMap<UnitCreate, Unit>()
                .ForMember(_ => _.Id, _ => _.Ignore());

            CreateMap<UnitUpdate, Unit>();
        }
    }
}
