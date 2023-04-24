using Ekobit.Ekoship.SmartHome.Data.Models;

namespace Ekobit.Ekoship.SmartHome.Services.Contracts
{
    public interface IDeviceTypeService
    {
        public IEnumerable<DeviceType> GetAllDeviceTypes();

        public DeviceType? GetDeviceTypeById(int id);

        public int CreateDeviceType(DeviceType deviceType);

        public int UpdateDeviceType(DeviceType deviceType);

        public bool DeleteDeviceType(int id);
    }
}
