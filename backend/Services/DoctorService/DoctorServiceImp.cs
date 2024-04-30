using Data;
using Domain.Dtos;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DoctorService
{
    public class DoctorServiceImp : IDoctorService
    {
        readonly ApplicationDbContext _context;

        public DoctorServiceImp(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Doctor>> GetAllDoctors()
        {
            return await _context.Doctors.ToListAsync();
        }
        public async Task<Doctor> GetDoctorById(int id)
        {
            return await _context.Doctors.FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<bool> DoctorExists(int id)
        {
            return await _context.Doctors.AnyAsync(d => d.Id == id);
        }

        public async Task<bool> CreateDoctor(DoctorCreationDto doctorDto)
        {
            // Map DoctorCreationDto to Doctor entity
            var newDoctor = new Doctor
            {
                FirstName = doctorDto.FirstName,
                LastName = doctorDto.LastName,
                Birthday = doctorDto.Birthday,
                Address = doctorDto.Address,
                DoctorServices = new List<Domain.Entities.DoctorService>() // Initialize DoctorServices collection
            };

            try
            {
                // Convert array of service IDs to HashSet for efficient lookup
                var serviceIdsHashSet = new HashSet<int>(doctorDto.ServiceIds);

                // Retrieve services based on the provided serviceIds
                var services = await _context.Services.Where(s => serviceIdsHashSet.Contains(s.Id)).ToListAsync();

                // Associate the retrieved services with the doctor
                foreach (var service in services)
                {
                    newDoctor.DoctorServices.Add(new Domain.Entities.DoctorService { Doctor = newDoctor, Service = service });
                }

                // Add the doctor to the context
                _context.Doctors.Add(newDoctor);

                // Save changes
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"Error creating doctor: {ex.Message}");
                return false;
            }

        }

        public async Task<bool> UpdateDoctor(int id, DoctorCreationDto doctorDto)
        {
            var existingDoctor = await _context.Doctors
                   .Include(d => d.DoctorServices)
                   .FirstOrDefaultAsync(d => d.Id == id);
            if (existingDoctor == null)
            {
                return false; // Doctor not found
            }

            // Map DoctorCreationDto to existing Doctor entity
            existingDoctor.FirstName = doctorDto.FirstName;
            existingDoctor.LastName = doctorDto.LastName;
            existingDoctor.Birthday = doctorDto.Birthday;
            existingDoctor.Address = doctorDto.Address;

            // Clear existing doctor services


            try
            {
                /*   if (existingDoctor.DoctorServices != null)
                   {
                       existingDoctor.DoctorServices.Clear();
                   }
                   else
                   {
                       existingDoctor.DoctorServices = new List<Domain.Entities.DoctorService>();
                   }*/
                _context.DoctorServices.RemoveRange(existingDoctor.DoctorServices);
                // Convert array of service IDs to HashSet for efficient lookup
                var serviceIdsHashSet = new HashSet<int>(doctorDto.ServiceIds);

                // Retrieve services based on the provided serviceIds
                var services = await _context.Services.Where(s => serviceIdsHashSet.Contains(s.Id)).ToListAsync();

                // Associate the retrieved services with the doctor
                foreach (var service in services)
                {
                    existingDoctor.DoctorServices.Add(new Domain.Entities.DoctorService { Doctor = existingDoctor, Service = service });
                }

                // Add the doctor to the context

                _context.Update(existingDoctor);

                // Save changes
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"Error Updating doctor: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteDoctor(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
            {
                return false;
            }

            _context.Doctors.Remove(doctor);
            return await Save();
        }

        public async Task<bool> Save()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                // Handle concurrency exception
                return false;
            }
        }
    }
}
