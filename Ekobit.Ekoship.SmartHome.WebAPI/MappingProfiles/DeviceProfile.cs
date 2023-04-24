using AutoMapper;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.WebAPI.Models.Device;

namespace Ekobit.Ekoship.SmartHome.WebAPI.MappingProfiles
{
    public class DeviceProfile : Profile
    {
        public DeviceProfile()
        {
            CreateMap<Device, DeviceList>();

            CreateMap<Device, DeviceDetails>()
                .ForMember(_ => _.Type, _ => _.MapFrom(_ => _.Type.Name))
                .ForMember(_ => _.Unit, _ => _.MapFrom(_ => _.Unit.Name))
                .ForMember(_ => _.HomeName, _ => _.MapFrom(_ => _.Home.Name));

            CreateMap<DeviceCreate, Device>()
                .ForMember(_ => _.LastUpdated, _ => _.MapFrom(_ => DateTime.Now))
                .ForMember(_ => _.DeviceTypeId, _ => _.MapFrom(_ => _.TypeId));

            CreateMap<DeviceUpdate, Device>()
                .ForMember(_ => _.LastUpdated, _ => _.MapFrom(_ => DateTime.Now))
                .ForMember(_ => _.DeviceTypeId, _ => _.MapFrom(_ => _.TypeId));
        }
    }
}
