using Ekobit.Ekoship.SmartHome.Data.Models;

namespace Ekobit.Ekoship.SmartHome.Services.Contracts
{
    public interface IAddressService
    {
        public IEnumerable<Address> GetAllAddresses();

        public Address? GetAddressById(int id);

        public int CreateAddress(Address address);

        public int UpdateAddress(Address address);

        public bool DeleteAddress(int id);
    }
}
