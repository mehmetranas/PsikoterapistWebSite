using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class MottoRepository : IMottoRepository
    {
        private readonly ApplicationDbContext _context;

        public MottoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Motto motto)
        {
            _context.Mottoes.Add(motto);
        }

        public IEnumerable<Motto> GetMottoes()
        {
            return _context.Mottoes.ToList();
        }

        public Motto GetMotto(int? id)
        {
            var motto = _context.Mottoes.SingleOrDefault(m => m.Id == id);
            return motto;
        }

        public void Delete(int? id)
        {
            var motto = _context.Mottoes.SingleOrDefault(m => m.Id == id);
            if (motto == null) return;

            _context.Mottoes.Remove(motto);
        }
    }
}