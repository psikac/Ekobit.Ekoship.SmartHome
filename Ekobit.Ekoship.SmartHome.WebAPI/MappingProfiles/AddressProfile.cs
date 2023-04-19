using AutoMapper;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.WebAPI.Models.Address;

namespace Ekobit.Ekoship.SmartHome.WebAPI.MappingProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressDetails>();

            CreateMap<AddressCreate, Address>()
                .ForMember(_ => _.Id, _ => _.Ignore());

            CreateMap<AddressUpdate, Address>();
        }
    }
}
