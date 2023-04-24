using Ekobit.Ekoship.SmartHome.Data;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Ekobit.Ekoship.SmartHome.Services.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly SmartHomeContext _context;

        public HomeRepository(SmartHomeContext context)
        {
            _context = context;
        }

        public IEnumerable<Home> GetAll()
        {
            return _context.Homes
                .Include(_ => _.Address);
        }

        public Home? GetById(int id)
        {
            return _context.Homes
                .Include(_ => _.Address)
                .FirstOrDefault(home => home.Id == id);
        }

        public int Create(Home home)
        {
            _context.Homes.Add(home);
            _context.SaveChanges();
            return home.Id;
        }

        public int Update(Home home)
        {
            _context.Homes.Update(home);
            _context.SaveChanges();
            return home.Id;
        }

        public bool Delete(int id)
        {
            var home = _context.Homes.FirstOrDefault(home => home.Id == id);
            if (home != null)
            {
                _context.Homes.Remove(home);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
