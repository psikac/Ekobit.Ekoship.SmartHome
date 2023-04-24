using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;

namespace Ekobit.Ekoship.SmartHome.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;

        public DeviceService(IDeviceRepository DeviceRepository)
        { 
            _deviceRepository = DeviceRepository;
        }

        public IEnumerable<Device> GetAllDevices()
        {
            return _deviceRepository.GetAll();
        }

        public IEnumerable<Device> GetAllHomeDevices(int homeId)
        {
            return _deviceRepository.GetAll().Where(device => device.HomeId == homeId);
        }

        public Device? GetDeviceById(int id)
        {
            return _deviceRepository.GetById(id);
        }

        public int CreateDevice(Device Device)
        {
            var newDeviceId = _deviceRepository.Create(Device);
            return newDeviceId;
        }

        public int UpdateDevice(Device Device)
        {
            var newDeviceId = _deviceRepository.Update(Device);
            return newDeviceId;
        }

        public bool DeleteDevice(int id)
        {
            var isDeleted = _deviceRepository.Delete(id);
            return isDeleted;
        }
    }
}
