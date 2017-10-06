using System.Collections.Generic;
using PsychotherapistWebSite.Core.Models;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IMessageRepository
    {
        void Add(Message message);
        void Delete(int id);
        void Read(int id);
        IEnumerable<Message> GetMessages();
        Message GetrMessage(int id);
    }
}