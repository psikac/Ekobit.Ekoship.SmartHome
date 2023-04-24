using Ekobit.Ekoship.SmartHome.Data.Models;

namespace Ekobit.Ekoship.SmartHome.Services.Contracts
{
    public interface IUnitService
    {
        public IEnumerable<Unit> GetAllUnits();

        public Unit? GetUnitById(int id);

        public int CreateUnit(Unit unit);

        public int UpdateUnit(Unit unit);

        public bool DeleteUnit(int id);
    }
}
