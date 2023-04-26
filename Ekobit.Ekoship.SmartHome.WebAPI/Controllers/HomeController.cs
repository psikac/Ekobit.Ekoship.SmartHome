using AutoMapper;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;
using Ekobit.Ekoship.SmartHome.WebAPI.Models.Home;
using Microsoft.AspNetCore.Mvc;

namespace Ekobit.Ekoship.SmartHome.WebAPI.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IHomeService _homeService;

        public HomeController(IMapper mapper, IHomeService homeService)
        {
            _mapper = mapper;
            _homeService = homeService;
        }

        [HttpGet]
        [Produces(typeof(IEnumerable<HomeList>))]
        public IActionResult GetHome()
        {
            var homes = _homeService.GetAllHomes();
            var result = _mapper.Map<IEnumerable<HomeList>>(homes);

            return Ok(result);
        }

        [HttpGet("{id}")]
        [Produces(typeof(HomeDetails))]
        public IActionResult GetHomeById(int id)
        {
            var home = _homeService.GetHomeById(id);
            var result = _mapper.Map<HomeDetails>(home);

            return Ok(result);
        }

        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult CreateHome([FromBody] HomeCreate newHome)
        {
            var home = _mapper.Map<Home>(newHome);
            var result = _homeService.CreateHome(home);

            return Ok(result);
        }

        [HttpPut("{id}")]
        [Produces(typeof(int))]
        public IActionResult UpdateHome([FromBody] HomeUpdate changedHome, int id)
        {
            var home = _mapper.Map<Home>(changedHome);
            home.Id = id;
            var result = _homeService.UpdateHome(home);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        [Produces(typeof(bool))]
        public IActionResult DeleteHome(int id)
        {
            var result = _homeService.DeleteHome(id);

            return Ok(result);
        }
    }
}
