using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Seed
    {
        private readonly ApplicationDbContext _context;

        public Seed(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SeedDataContext()
        {
            if (!_context.Services.Any())
            {
                var services = new List<Service>
                {
                    new Service { Name = "Service1", Description = "Description1" },
                    new Service { Name = "Service2", Description = "Description2" },
                    // Add more services as needed
                };

                _context.Services.AddRange(services);
                _context.SaveChanges();
            }

            if (!_context.Doctors.Any())
            {
                var doctors = new List<Doctor>
                {
                    new Doctor { FirstName = "John", LastName = "Doe", Birthday = new DateTime(1980, 1, 1), Address = "123 Main St" },
                    new Doctor { FirstName = "Jane", LastName = "Smith", Birthday = new DateTime(1975, 5, 5), Address = "456 Elm St" },
                    // Add more doctors as needed
                };

                _context.Doctors.AddRange(doctors);
                _context.SaveChanges();
            }

            if (!_context.Patients.Any())
            {
                var patients = new List<Patient>
                {
                    new Patient { UserName = "patient1", Phone = 12345678, ServiceId = 1 },
                    new Patient { UserName = "patient2", Phone = 98765432, ServiceId = 2 },
                    // Add more patients as needed
                };

                _context.Patients.AddRange(patients);
                _context.SaveChanges();
            }

            if (!_context.DoctorServices.Any())
            {
                var doctorServices = new List<DoctorService>
                {
                    new DoctorService { DoctorId = 1, ServiceId = 1},
                    new DoctorService { DoctorId = 2, ServiceId = 2},
                    // Add more doctor-service relationships as needed
                };

                _context.DoctorServices.AddRange(doctorServices);
                _context.SaveChanges();
            }

        }
    }
}
