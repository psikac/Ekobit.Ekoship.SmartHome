using Ekobit.Ekoship.SmartHome.Data.Models;

namespace Ekobit.Ekoship.SmartHome.Services.Contracts
{
    public interface IHomeRepository
    {
        public IEnumerable<Home> GetAll();

        public Home? GetById(int id);

        public int Create(Home home);

        public int Update(Home home);

        public bool Delete(int id);
    }
}
