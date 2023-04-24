using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;

namespace Ekobit.Ekoship.SmartHome.Services
{
    public class UnitService : IUnitService
    {
        private readonly IUnitRepository _unitRepository;

        public UnitService(IUnitRepository unitRepository)
        { 
            _unitRepository = unitRepository;
        }

        public IEnumerable<Unit> GetAllUnits()
        {
            return _unitRepository.GetAll();
        }

        public Unit? GetUnitById(int id)
        {
            return _unitRepository.GetById(id);
        }

        public int CreateUnit(Unit Unit)
        {
            var newUnitId = _unitRepository.Create(Unit);
            return newUnitId;
        }

        public int UpdateUnit(Unit Unit)
        {
            var newUnitId = _unitRepository.Update(Unit);
            return newUnitId;
        }

        public bool DeleteUnit(int id)
        {
            var isDeleted = _unitRepository.Delete(id);
            return isDeleted;
        }
    }
}
