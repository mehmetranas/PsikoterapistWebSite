using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class ServiceRepository: IServiceRepository
    {
        private readonly ApplicationDbContext _context;

        public ServiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddService(Service service)
        {
            _context.Services.Add(service);
        }

        public void DeleteService(int id)
        {
            var service = _context.Services.FirstOrDefault(s => s.Id == id);
            if (service != null) _context.Services.Remove(service);
        }

        public void PutService(Service service)
        {
            var serviceDb = _context.Services.FirstOrDefault(s => s.Id == service.Id);
            if (serviceDb == null) return;
            Mapper.Map(service,serviceDb);
        }

        public IEnumerable<Service> GetServices()
        {
            var services = _context.Services
                .Include(s => s.Images)
                .ToList();
            return services;
        }

        public Service GetService(int id)
        {
            var service = _context.Services
                .SingleOrDefault(s => s.Id == id);
            return service ?? null;
        }

    }
}
