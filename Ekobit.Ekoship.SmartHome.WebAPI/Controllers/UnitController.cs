using AutoMapper;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;
using Ekobit.Ekoship.SmartHome.WebAPI.Models.Unit;
using Microsoft.AspNetCore.Mvc;

namespace Ekobit.Ekoship.SmartHome.WebAPI.Controllers
{
    [ApiController]
    [Route("unit")]
    public class UnitController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitService _unitService;

        public UnitController(IMapper mapper, IUnitService unitService) 
        {
            _mapper = mapper;
            _unitService = unitService;
        }

        [HttpGet]
        [Produces(typeof(IEnumerable<UnitDetails>))]
        public IActionResult GetUnites()
        {
            var unites = _unitService.GetAllUnits();
            var result = _mapper.Map<IEnumerable<UnitDetails>>(unites);

            return Ok(result);
        }

        [HttpGet("id")]
        [Produces(typeof(UnitDetails))]
        public IActionResult GetUnitById(int id)
        {
            var unit = _unitService.GetUnitById(id);
            var result = _mapper.Map<UnitDetails>(unit);

            return Ok(result);
        }

        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult CreateUnit([FromBody] UnitCreate newUnit)
        {
            var unit = _mapper.Map<Unit>(newUnit);
            var result = _unitService.CreateUnit(unit);

            return Ok(result);
        }

        [HttpPut("id")]
        [Produces(typeof(int))]
        public IActionResult UpdateUnit([FromBody] UnitUpdate changedUnit, int id)
        {
            var unit = _mapper.Map<Unit>(changedUnit);
            unit.Id = id;
            var result = _unitService.UpdateUnit(unit);

            return Ok(result);
        }

        [HttpDelete("id")]
        [Produces(typeof(bool))]
        public IActionResult DeleteUnit(int id)
        {
            var result = _unitService.DeleteUnit(id);

            return Ok(result);
        }
    }
}
