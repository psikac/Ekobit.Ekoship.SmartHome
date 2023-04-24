using AutoMapper;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;
using Ekobit.Ekoship.SmartHome.WebAPI.Models.DeviceType;
using Microsoft.AspNetCore.Mvc;

namespace Ekobit.Ekoship.SmartHome.WebAPI.Controllers
{
    [ApiController]
    [Route("deviceType")]
    public class DeviceTypeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDeviceTypeService _deviceTypeService;

        public DeviceTypeController(IMapper mapper, IDeviceTypeService deviceTypeService) 
        {
            _mapper = mapper;
            _deviceTypeService = deviceTypeService;
        }

        [HttpGet]
        [Produces(typeof(IEnumerable<DeviceTypeDetails>))]
        public IActionResult GetDeviceTypes()
        {
            var deviceTypees = _deviceTypeService.GetAllDeviceTypes();
            var result = _mapper.Map<IEnumerable<DeviceTypeDetails>>(deviceTypees);

            return Ok(result);
        }

        [HttpGet("id")]
        [Produces(typeof(DeviceTypeDetails))]
        public IActionResult GetDeviceTypeById(int id)
        {
            var deviceType = _deviceTypeService.GetDeviceTypeById(id);
            var result = _mapper.Map<DeviceTypeDetails>(deviceType);

            return Ok(result);
        }

        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult CreateDeviceType([FromBody] DeviceTypeCreate newDeviceType)
        {
            var deviceType = _mapper.Map<DeviceType>(newDeviceType);
            var result = _deviceTypeService.CreateDeviceType(deviceType);

            return Ok(result);
        }

        [HttpPut("id")]
        [Produces(typeof(int))]
        public IActionResult UpdateDeviceType([FromBody] DeviceTypeUpdate changedDeviceType, int id)
        {
            var deviceType = _mapper.Map<DeviceType>(changedDeviceType);
            deviceType.Id = id;
            var result = _deviceTypeService.UpdateDeviceType(deviceType);

            return Ok(result);
        }

        [HttpDelete("id")]
        [Produces(typeof(bool))]
        public IActionResult DeleteDeviceType(int id)
        {
            var result = _deviceTypeService.DeleteDeviceType(id);

            return Ok(result);
        }
    }
}
