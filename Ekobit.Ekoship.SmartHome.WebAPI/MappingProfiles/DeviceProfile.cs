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
                .ForMember(_ => _.Id, _ => _.Ignore());

            CreateMap<DeviceCreate, Device>();

            CreateMap<DeviceUpdate, Device>();
        }
    }
}
