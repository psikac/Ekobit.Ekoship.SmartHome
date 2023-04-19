using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;

namespace Ekobit.Ekoship.SmartHome.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        { 
            _addressRepository = addressRepository;
        }

        public IEnumerable<Address> GetAllAddresses()
        {
            return _addressRepository.GetAll();
        }

        public Address? GetAddressById(int id)
        {
            return _addressRepository.GetById(id);
        }

        public int CreateAddress(Address address)
        {
            var newAddressId = _addressRepository.Create(address);
            return newAddressId;
        }

        public int UpdateAddress(Address address)
        {
            var newAddressId = _addressRepository.Update(address);
            return newAddressId;
        }

        public bool DeleteAddress(int id)
        {
            var isDeleted = _addressRepository.Delete(id);
            return isDeleted;
        }
    }
}
