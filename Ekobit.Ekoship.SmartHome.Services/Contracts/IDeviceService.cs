using Ekobit.Ekoship.SmartHome.Data.Models;

namespace Ekobit.Ekoship.SmartHome.Services.Contracts
{
    public interface IDeviceService
    {
        public IEnumerable<Device> GetAllDevices();

        public Device? GetDeviceById(int id);

        public int CreateDevice(Device device);

        public int UpdateDevice(Device device);

        public bool DeleteDevice(int id);
    }
}
