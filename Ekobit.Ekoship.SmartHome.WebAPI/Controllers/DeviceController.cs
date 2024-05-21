using AutoMapper;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;
using Ekobit.Ekoship.SmartHome.WebAPI.Models.Device;
using Microsoft.AspNetCore.Mvc;

namespace Ekobit.Ekoship.SmartHome.WebAPI.Controllers
{
    [ApiController]
    [Route("device")]
    public class DeviceController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDeviceService _deviceService;

        public DeviceController(IMapper mapper, IDeviceService deviceService) 
        {
            _mapper = mapper;
            _deviceService = deviceService;
        }

        [HttpGet]
        [Produces(typeof(IEnumerable<DeviceList>))]
        public IActionResult GetDevices()
        {
            var devices = _deviceService.GetAllDevices();
            var result = _mapper.Map<IEnumerable<DeviceList>>(devices);

            return Ok(result);
        }

        [HttpGet("{id}")]
        [Produces(typeof(DeviceDetails))]
        public IActionResult GetDeviceById(int id)
        {
            var device = _deviceService.GetDeviceById(id);
            var result = _mapper.Map<DeviceDetails>(device);

            return Ok(result);
        }

        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult CreateDevice([FromBody] DeviceCreate newDevice)
        {
            var device = _mapper.Map<Device>(newDevice);
            var result = _deviceService.CreateDevice(device);

            return Ok(result);
        }

        [HttpPut("{id}")]
        [Produces(typeof(int))]
        public IActionResult UpdateDevice([FromBody] DeviceUpdate changedDevice, int id)
        {
            var device = _mapper.Map<Device>(changedDevice);
            device.Id = id;
            var result = _deviceService.UpdateDevice(device);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        [Produces(typeof(bool))]
        public IActionResult DeleteDevice(int id)
        {
            var result = _deviceService.DeleteDevice(id);

            return Ok(result);
        }
    }
}
