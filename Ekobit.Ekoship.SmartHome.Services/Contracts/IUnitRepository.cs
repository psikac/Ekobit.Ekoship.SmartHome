using Ekobit.Ekoship.SmartHome.Data.Models;

namespace Ekobit.Ekoship.SmartHome.Services.Contracts
{
    public interface IUnitRepository
    {
        public IEnumerable<Unit> GetAll();

        public Unit? GetById(int id);

        public int Create(Unit unit);

        public int Update(Unit unit);

        public bool Delete(int id);
    }
}
