using System.Linq;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;

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
                _context.Messageses.Add(message);
        }
    }
}