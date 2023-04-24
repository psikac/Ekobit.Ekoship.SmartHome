using Ekobit.Ekoship.SmartHome.Data;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;

namespace Ekobit.Ekoship.SmartHome.Services.Repositories
{
    public class DeviceTypeRepository : IDeviceTypeRepository
    {
        private readonly SmartHomeContext _context;

        public DeviceTypeRepository(SmartHomeContext context)
        {
            _context = context;
        }

        public IEnumerable<DeviceType> GetAll()
        {
            return _context.DeviceTypes;
        }

        public DeviceType? GetById(int id)
        {
            return _context.DeviceTypes.FirstOrDefault(DeviceType => DeviceType.Id == id);
        }

        public int Create(DeviceType DeviceType)
        {
            _context.DeviceTypes.Add(DeviceType);
            _context.SaveChanges();
            return DeviceType.Id;
        }

        public int Update(DeviceType DeviceType)
        {
            _context.DeviceTypes.Update(DeviceType);
            _context.SaveChanges();
            return DeviceType.Id;
        }

        public bool Delete(int id)
        {
            var DeviceType = _context.DeviceTypes.FirstOrDefault(DeviceType => DeviceType.Id == id);
            if(DeviceType != null)
            {
                _context.DeviceTypes.Remove(DeviceType);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
