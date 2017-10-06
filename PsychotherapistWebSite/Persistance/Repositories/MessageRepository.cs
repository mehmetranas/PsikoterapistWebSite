using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;
using System.Collections.Generic;
using System.Linq;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class MessageRepository: IMessageRepository  
    {
        private readonly ApplicationDbContext _context;

        public MessageRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public void Add(Message message)
        {
            _context.Messages.Add(message);
        }

        public void Delete(int id)
        {
            var message = _context.Messages.FirstOrDefault(m => m.Id == id);
            if (message != null) _context.Messages.Remove(message);
        }

        public void Read(int id)
        {
            var message = _context.Messages.FirstOrDefault(m => m.Id == id);
            if (message != null) message.IsRead = true;
        }

        public IEnumerable<Message> GetMessages()
        {
            return _context.Messages.ToList();
        }

        public Message GetrMessage(int id)
        {
            return _context.Messages.FirstOrDefault(m => m.Id == id);
        }
    }
}