using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PatientService
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAllPatients();
        Task<Patient> GetPatientById(int id);
        Task<bool> PatientExists(int id);
        Task<bool> CreatePatient(PatientCreationDto patientDto);
        Task<bool> UpdatePatient(int id, PatientCreationDto patientDto);
        Task<bool> DeletePatient(int id);
        Task<bool> SavePatient();
    }
}
