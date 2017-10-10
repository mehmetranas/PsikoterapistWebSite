using PsychotherapistWebSite.Core.Models;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IMessageRepository
    {
        void Add(Messages message);
        void Delete(int id);
    }
}