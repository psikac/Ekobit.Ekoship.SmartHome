using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Repositories;

namespace Ekobit.Ekoship.SmartHome.Services.Contracts
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;

        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public IEnumerable<Device> GetAllDevices()
        {
            return _deviceRepository.GetAll();
        }

        public Device? GetDeviceById(int id)
        {
            return _deviceRepository.GetById(id);
        }

        public int CreateDevice(Device device)
        {
            // purposefully not checked on frontend for testers
            if (!device.SerialNr.All(c => Char.IsLetterOrDigit(c)))
            {
                throw new Exception("Device serial number contains non-alphanumeric symbols");
            }

            // purposefully not checked on frontend for testers
            if (device.SerialNr.Length < 2)
            {
                throw new Exception("Device serial number contains less than 2 characters");
            }

            var newDeviceId = _deviceRepository.Create(device);
            return newDeviceId;
        }

        public int UpdateDevice(Device device)
        {
            var newDeviceId = _deviceRepository.Update(device);
            return newDeviceId;
        }

        public bool DeleteDevice(int id)
        {
            var isDeleted = _deviceRepository.Delete(id);
            return isDeleted;
        }
    }
}
