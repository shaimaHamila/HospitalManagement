using Data;
using Domain.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.PatientService;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            var patients = await _patientService.GetAllPatients();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientById([FromRoute] int id)
        {
            var patient = await _patientService.GetPatientById(id);
            if (patient == null)
            {
                return NotFound($"Patient with ID {id} not found");
            }
            return Ok(patient);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePatient([FromBody] PatientCreationDto patientDto)
        {
            var result = await _patientService.CreatePatient(patientDto);
            if (result)
            {
                return Ok("Patient created successfully");
            }
            return BadRequest("Failed to create patient");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePatient([FromRoute] int id, [FromBody] PatientCreationDto patientDto)
        {
            var result = await _patientService.UpdatePatient(id, patientDto);
            if (result)
            {
                return Ok($"Patient with ID {id} updated successfully");
            }
            return NotFound($"Patient with ID {id} not found");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient([FromRoute] int id)
        {
            var result = await _patientService.DeletePatient(id);
            if (result)
            {
                return Ok($"Patient with ID {id} deleted successfully");
            }
            return NotFound($"Patient with ID {id} not found");
        }
    }

}

