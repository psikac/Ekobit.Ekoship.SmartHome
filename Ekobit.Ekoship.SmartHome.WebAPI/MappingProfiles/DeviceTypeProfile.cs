using AutoMapper;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.WebAPI.Models.DeviceType;

namespace Ekobit.Ekoship.SmartHome.WebAPI.MappingProfiles
{
    public class DeviceTypeProfile : Profile
    {
        public DeviceTypeProfile()
        {
            CreateMap<DeviceType, DeviceTypeDetails>();

            CreateMap<DeviceTypeCreate, DeviceType>()
                .ForMember(_ => _.Id, _ => _.Ignore());

            CreateMap<DeviceTypeUpdate, DeviceType>();
        }
    }
}
