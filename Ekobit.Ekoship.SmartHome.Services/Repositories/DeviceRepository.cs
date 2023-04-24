using Ekobit.Ekoship.SmartHome.Data;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Ekobit.Ekoship.SmartHome.Services.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly SmartHomeContext _context;

        public DeviceRepository(SmartHomeContext context)
        {
            _context = context;
        }

        public IEnumerable<Device> GetAll()
        {
            return _context.Devices
                        .Include(device => device.Type)
                        .Include(device => device.Unit)
                        .Include(device => device.Home);
        }

        public Device? GetById(int id)
        {
            return _context.Devices
                        .Include(device => device.Type)
                        .Include(device => device.Unit)
                        .Include(device => device.Home)
                        .FirstOrDefault(Device => Device.Id == id);
        }

        public int Create(Device device)
        {
            _context.Devices.Add(device);
            _context.SaveChanges();
            return device.Id;
        }

        public int Update(Device device)
        {
            _context.Devices.Update(device);
            _context.SaveChanges();
            return device.Id;
        }

        public bool Delete(int id)
        {
            var device = _context.Devices.FirstOrDefault(device => device.Id == id);
            if(device != null)
            {
                _context.Devices.Remove(device);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
