
using Data;
using Domain.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.DoctorService;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDoctors()
        {
            var doctors = await _doctorService.GetAllDoctors();
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctorById([FromRoute] int id)
        {
            var doctor = await _doctorService.GetDoctorById(id);
            if (doctor == null)
            {
                return NotFound($"Doctor with ID {id} not found");
            }

            return Ok(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDoctor([FromBody] DoctorCreationDto doctorDto)
        {
            var (resNewDoctor, success) = await _doctorService.CreateDoctor(doctorDto);
            if (success)
            {
                return Ok(resNewDoctor);
            }
            return BadRequest("Failed to create doctor");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDoctor([FromRoute] int id, [FromBody] DoctorCreationDto doctorDto)
        {
            var (resUpdatedDoctor, success) = await _doctorService.UpdateDoctor(id, doctorDto);
            if (success)
            {
                return Ok(resUpdatedDoctor);
            }
            return BadRequest($"Failed to update doctor with ID {id} ");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor([FromRoute] int id)
        {
            var result = await _doctorService.DeleteDoctor(id);
            if (result)
            {
                return Ok(id);
            }
            return NotFound($"Doctor with ID {id} not found");
        }
    }
}
