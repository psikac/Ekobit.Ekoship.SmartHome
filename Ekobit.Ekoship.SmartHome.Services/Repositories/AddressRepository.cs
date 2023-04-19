using Ekobit.Ekoship.SmartHome.Data;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;

namespace Ekobit.Ekoship.SmartHome.Services.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly SmartHomeContext _context;

        public AddressRepository(SmartHomeContext context)
        {
            _context = context;
        }

        public IEnumerable<Address> GetAll()
        {
            return _context.Addresses;
        }

        public Address? GetById(int id)
        {
            return _context.Addresses.FirstOrDefault(address => address.Id == id);
        }

        public int Create(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return address.Id;
        }

        public int Update(Address address)
        {
            _context.Addresses.Update(address);
            _context.SaveChanges();
            return address.Id;
        }

        public bool Delete(int id)
        {
            var address = _context.Addresses.FirstOrDefault(address => address.Id == id);
            if(address != null)
            {
                _context.Addresses.Remove(address);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
