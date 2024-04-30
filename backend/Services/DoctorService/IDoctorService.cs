using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DoctorService
{
    public interface IDoctorService
    {
        Task<IEnumerable<Doctor>> GetAllDoctors();
        Task<Doctor> GetDoctorById(int id);
        Task<bool> DoctorExists(int id);
        Task<bool> CreateDoctor(DoctorCreationDto doctorDto);
        Task<bool> UpdateDoctor(int id, DoctorCreationDto doctorDto);
        Task<bool> DeleteDoctor(int id);
        Task<bool> Save();
    }
}
