using AutoMapper;
using Ekobit.Ekoship.SmartHome.Data.Models;
using Ekobit.Ekoship.SmartHome.Services.Contracts;
using Ekobit.Ekoship.SmartHome.WebAPI.Models.Address;
using Microsoft.AspNetCore.Mvc;

namespace Ekobit.Ekoship.SmartHome.WebAPI.Controllers
{
    [ApiController]
    [Route("address")]
    public class AddressController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAddressService _addressService;

        public AddressController(IMapper mapper, IAddressService addressService) 
        {
            _mapper = mapper;
            _addressService = addressService;
        }

        [HttpGet]
        [Produces(typeof(IEnumerable<AddressDetails>))]
        public IActionResult GetAddresses()
        {
            var addresses = _addressService.GetAllAddresses();
            var result = _mapper.Map<IEnumerable<AddressDetails>>(addresses);

            return Ok(result);
        }

        [HttpGet("id")]
        [Produces(typeof(AddressDetails))]
        public IActionResult GetAddressById(int id)
        {
            var address = _addressService.GetAddressById(id);
            var result = _mapper.Map<AddressDetails>(address);

            return Ok(result);
        }

        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult CreateAddress([FromBody] AddressCreate newAddress)
        {
            var address = _mapper.Map<Address>(newAddress);
            var result = _addressService.CreateAddress(address);

            return Ok(result);
        }

        [HttpPut("id")]
        [Produces(typeof(int))]
        public IActionResult UpdateAddress([FromBody] AddressUpdate changedAddress, int id)
        {
            var address = _mapper.Map<Address>(changedAddress);
            address.Id = id;
            var result = _addressService.UpdateAddress(address);

            return Ok(result);
        }

        [HttpDelete("id")]
        [Produces(typeof(bool))]
        public IActionResult DeleteAddress(int id)
        {
            var result = _addressService.DeleteAddress(id);

            return Ok(result);
        }
    }
}
