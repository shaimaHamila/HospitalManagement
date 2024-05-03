using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceService
{
    public interface IServiceService
    {
        Task<IEnumerable<Service>> GetAllServices();
        Task<Service> GetServiceById(int id);
        Task<bool> ServiceExists(int id);
        Task<(Service service, bool success)> CreateService(Service service);
        Task<bool> UpdateService(int id, Service service);
        Task<bool> DeleteService(int id);
        Task<bool> SaveService();
    }
}
