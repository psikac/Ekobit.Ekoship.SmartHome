using AutoMapper;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.WebAPI.Models.Home;

namespace Ekobit.Ekoship.SmartHome.WebAPI.MappingProfiles
{
    public class HomeProfile : Profile
    {
        public HomeProfile()
        {
            CreateMap<Home, HomeList>();

            CreateMap<Home, HomeDetails>()
                .ForMember(_ => _.StreetName, _ => _.MapFrom(_ => _.Address != null ? _.Address.StreetName : String.Empty))
                .ForMember(_ => _.Number, _ => _.MapFrom(_ => _.Address != null ? _.Address.Number : (int?)null))
                .ForMember(_ => _.City, _ => _.MapFrom(_ => _.Address != null ? _.Address.City : String.Empty))
                .ForMember(_ => _.ZipCode, _ => _.MapFrom(_ => _.Address != null ? _.Address.ZipCode : (int?)null))
                .ForMember(_ => _.Country, _ => _.MapFrom(_ => _.Address != null ? _.Address.Country : String.Empty));

            CreateMap<HomeCreate, Home>();

            CreateMap<HomeUpdate, Home>();
        }
    }
}
