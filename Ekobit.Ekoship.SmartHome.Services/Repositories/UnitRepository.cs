using Ekobit.Ekoship.SmartHome.Data;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;

namespace Ekobit.Ekoship.SmartHome.Services.Repositories
{
    public class UnitRepository : IUnitRepository
    {
        private readonly SmartHomeContext _context;

        public UnitRepository(SmartHomeContext context)
        {
            _context = context;
        }

        public IEnumerable<Unit> GetAll()
        {
            return _context.Units;
        }

        public Unit? GetById(int id)
        {
            return _context.Units.FirstOrDefault(Unit => Unit.Id == id);
        }

        public int Create(Unit Unit)
        {
            _context.Units.Add(Unit);
            _context.SaveChanges();
            return Unit.Id;
        }

        public int Update(Unit Unit)
        {
            _context.Units.Update(Unit);
            _context.SaveChanges();
            return Unit.Id;
        }

        public bool Delete(int id)
        {
            var Unit = _context.Units.FirstOrDefault(Unit => Unit.Id == id);
            if(Unit != null)
            {
                _context.Units.Remove(Unit);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
