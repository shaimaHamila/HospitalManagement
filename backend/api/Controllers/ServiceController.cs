using Data;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.ServiceService;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllServices()
        {
            var services = await _serviceService.GetAllServices();
            return Ok(services);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceById([FromRoute] int id)
        {
            var service = await _serviceService.GetServiceById(id);
            if (service == null)
            {
                return NotFound($"Service with ID {id} not found");
            }
            return Ok(service);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService([FromBody] Service service)
        {
            var (nawService, res) = await _serviceService.CreateService(service);
            if (res)
            {
                return Ok(nawService);
            }
            return BadRequest("Failed to create service");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateService([FromRoute] int id, [FromBody] Service service)
        {
            var result = await _serviceService.UpdateService(id, service);
            if (result)
            {
                return Ok(service);
            }
            return NotFound($"Service with ID {id} not found");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService([FromRoute] int id)
        {
            var result = await _serviceService.DeleteService(id);
            if (result)
            {
                return Ok($"Service with ID {id} deleted successfully");
            }
            return NotFound($"Service with ID {id} not found");
        }
    }
}
