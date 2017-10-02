using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class AdressRepository : IAdressRepository
    {
        private readonly ApplicationDbContext _context;

        public AdressRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Adress adress)
        {
            if (adress != null) _context.Adresses.Add(adress);
        }

        public void Delete(int? id)
        {
            if (id == null) return;
            var adress = _context.Adresses.FirstOrDefault(a => a.Id == id);
            if (adress != null)
                _context.Adresses.Remove(adress);
        }

        public IEnumerable<Adress> GetAdresses()
        {
            return _context.Adresses.ToList();
        }

        public Adress GetAdress(int? id)
        {
            return id == null ? null : _context.Adresses.FirstOrDefault(a => a.Id == id);
        }

        public void Put(Adress adress)
        {
            var adressDb = _context.Adresses.FirstOrDefault(a => a.Id == adress.Id);
            if (adressDb != null) Mapper.Map(adressDb, adress);
        }
    }
}