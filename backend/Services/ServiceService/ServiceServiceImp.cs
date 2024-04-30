using Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceService
{
    public class ServiceServiceImp : IServiceService
    {
        private readonly ApplicationDbContext _context;

        public ServiceServiceImp(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Service>> GetAllServices()
        {
            return await _context.Services.ToListAsync();
        }

        public async Task<Service> GetServiceById(int id)
        {
            return await _context.Services.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<bool> ServiceExists(int id)
        {
            return await _context.Services.AnyAsync(s => s.Id == id);
        }

        public async Task<bool> CreateService(Service service)
        {
            _context.Services.Add(service);
            return await SaveService();
        }

        public async Task<bool> UpdateService(int id, Service service)
        {
            _context.Entry(service).State = EntityState.Modified;
            return await SaveService();
        }

        public async Task<bool> DeleteService(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null)
                return false;

            _context.Services.Remove(service);
            return await SaveService();
        }

        public async Task<bool> SaveService()
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

