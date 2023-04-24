using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;

namespace Ekobit.Ekoship.SmartHome.Services
{
    public class DeviceTypeService : IDeviceTypeService
    {
        private readonly IDeviceTypeRepository _DeviceTypeRepository;

        public DeviceTypeService(IDeviceTypeRepository DeviceTypeRepository)
        {
            _DeviceTypeRepository = DeviceTypeRepository;
        }

        public IEnumerable<DeviceType> GetAllDeviceTypes()
        {
            return _DeviceTypeRepository.GetAll();
        }

        public DeviceType? GetDeviceTypeById(int id)
        {
            return _DeviceTypeRepository.GetById(id);
        }

        public int CreateDeviceType(DeviceType DeviceType)
        {
            var newDeviceTypeId = _DeviceTypeRepository.Create(DeviceType);
            return newDeviceTypeId;
        }

        public int UpdateDeviceType(DeviceType DeviceType)
        {
            var newDeviceTypeId = _DeviceTypeRepository.Update(DeviceType);
            return newDeviceTypeId;
        }

        public bool DeleteDeviceType(int id)
        {
            var isDeleted = _DeviceTypeRepository.Delete(id);
            return isDeleted;
        }
    }
}
