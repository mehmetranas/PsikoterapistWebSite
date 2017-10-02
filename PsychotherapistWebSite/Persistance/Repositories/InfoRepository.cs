using AutoMapper;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;
using System.Data.Entity;
using System.Linq;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class InfoRepository: IInfoRepository
    {
        private readonly ApplicationDbContext _context;

        public InfoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Info GetInfo()
        {
            return _context.Info
                .Include(i => i.Adress)
                .FirstOrDefault();
        }
    
        public void Add(Info info)
        {
            if (info != null) _context.Info.Add(info);
        }

        public void Delete()
        {
            var info = _context.Info.FirstOrDefault();
            if (info != null)
                _context.Info.Remove(info);
        }

        public void Put(Info info)
        {
            var infoDb = _context.Info.FirstOrDefault(i => i.Id == info.Id);
            if (infoDb != null)
                Mapper.Map(info,infoDb);
        }

        public string AboutMe()
        {
            var info = _context.Info.FirstOrDefault();
            return info?.AboutMe;
        }
    }
}