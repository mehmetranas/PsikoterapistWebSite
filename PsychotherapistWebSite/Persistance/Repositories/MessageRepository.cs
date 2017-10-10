using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;
using System.Data.Entity;
using System.Linq;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly ApplicationDbContext _context;

        public MessageRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Messages message)
        {
            if(message != null)
                _context.Messageses.Add(message);
        }

        public void Delete(int id)
        {
            var message = _context.Messageses.FirstOrDefault(m => m.Id == id);
            if (message != null)
                _context.Messageses.Remove(message);
        }

        public IQueryable<Messages> GetMessages()
        {
            return _context.Messageses.OrderByDescending(m => m.IsRead);
        }

        public Messages GetMessage(int? id)
        {
            if (id == null) return null;
            var message = _context.Messageses.FirstOrDefault(m => m.Id == id);
            return message;
        }

        public void Put(Messages messages)
        {
            if(messages == null) return;
            _context.Entry(messages).State = EntityState.Modified;
        }
    }
}