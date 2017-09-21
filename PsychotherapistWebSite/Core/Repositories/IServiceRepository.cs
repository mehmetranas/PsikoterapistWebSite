using PsychotherapistWebSite.Core.Models;
using System.Collections.Generic;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IServiceRepository
    {
        void AddService(Service service);
        void DeleteService(int id);
        void PutService(Service service);
        IEnumerable<Service> GetServices();
        Service GetService(int id);
    }
}