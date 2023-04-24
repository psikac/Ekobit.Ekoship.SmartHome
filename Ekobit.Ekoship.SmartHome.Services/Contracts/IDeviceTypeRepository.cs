using Ekobit.Ekoship.SmartHome.Data.Models;

namespace Ekobit.Ekoship.SmartHome.Services.Contracts
{
    public interface IDeviceTypeRepository
    {
        public IEnumerable<DeviceType> GetAll();

        public DeviceType? GetById(int id);

        public int Create(DeviceType deviceType);

        public int Update(DeviceType deviceType);

        public bool Delete(int id);
    }
}
