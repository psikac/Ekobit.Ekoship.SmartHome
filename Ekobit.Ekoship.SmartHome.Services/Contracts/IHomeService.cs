using Ekobit.Ekoship.SmartHome.Data.Models;

namespace Ekobit.Ekoship.SmartHome.Services.Contracts
{
    public interface IHomeService
    {
        public IEnumerable<Home> GetAllHomes();

        public Home? GetHomeById(int id);

        public int CreateHome(Home home);

        public int UpdateHome(Home home);

        public bool DeleteHome(int id);
    }
}
