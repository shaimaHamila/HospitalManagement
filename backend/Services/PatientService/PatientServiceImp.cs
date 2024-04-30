using Data;
using Domain.Dtos;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PatientService
{
    public class PatientServiceImp : IPatientService
    {
        private readonly ApplicationDbContext _context;

        public PatientServiceImp(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patient>> GetAllPatients()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<Patient> GetPatientById(int id)
        {
            return await _context.Patients.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> PatientExists(int id)
        {
            return await _context.Patients.AnyAsync(p => p.Id == id);
        }

        public async Task<bool> CreatePatient(PatientCreationDto patientDto)
        {
            // Retrieve the service associated with the provided service ID
            var service = await _context.Services.FindAsync(patientDto.ServiceId);
            if (service == null)
            {
                return false; // Service not found
            }

            // Create a new patient entity and map data from DTO
            var patient = new Patient
            {
                UserName = patientDto.UserName,
                Phone = patientDto.Phone,
                Service = service // Associate the patient with the retrieved service
            };

            _context.Patients.Add(patient);

            return await SavePatient();
        }

        public async Task<bool> UpdatePatient(int id, PatientCreationDto patientDto)
        {
            // Retrieve the existing patient entity from the database
            var existingPatient = await _context.Patients.FindAsync(id);
            if (existingPatient == null)
            {
                return false; // Patient not found
            }

            // Update the existing patient entity with data from the DTO
            existingPatient.UserName = patientDto.UserName;
            existingPatient.Phone = patientDto.Phone;

            // Retrieve the service associated with the provided service ID
            var service = await _context.Services.FindAsync(patientDto.ServiceId);
            if (service == null)
            {
                return false; // Service not found
            }

            // Associate the patient with the retrieved service
            existingPatient.Service = service;

            // Update the patient entity in the context
            _context.Patients.Update(existingPatient);

            // Save changes to the database
            return await SavePatient();
        }

        public async Task<bool> DeletePatient(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
                return false;

            _context.Patients.Remove(patient);
            return await SavePatient();
        }

        public async Task<bool> SavePatient()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }
    
    }
}
