using PsychotherapistWebSite.Core.Models;
using System.Linq;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IMessageRepository
    {
        void Add(Messages message);
        void Delete(int id);
        IQueryable<Messages> GetMessages();
        Messages GetMessage(int? id);
        void Put(Messages messages);
    }
}