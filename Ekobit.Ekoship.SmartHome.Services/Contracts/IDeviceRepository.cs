using Ekobit.Ekoship.SmartHome.Data.Models;

namespace Ekobit.Ekoship.SmartHome.Services.Contracts
{
    public interface IDeviceRepository
    {
        public IEnumerable<Device> GetAll();

        public Device? GetById(int id);

        public int Create(Device device);

        public int Update(Device device);

        public bool Delete(int id);
    }
}
