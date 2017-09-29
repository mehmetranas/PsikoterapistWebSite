using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class WelcomeTextRepository: IWelcomeTextRepository
    {
        private readonly ApplicationDbContext _context;

        public WelcomeTextRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Core.Models.WelcomeText GetWelcomeText()
        {
            var welcomeText = _context.WelcomeTexts.FirstOrDefault();
            return welcomeText ?? null;
        }

        public void Create(Core.Models.WelcomeText welcomeText)
        {
            if (welcomeText != null)
                _context.WelcomeTexts.Add(welcomeText);
        }

        public void Delete(int id)
        {
            var welcomeText = _context.WelcomeTexts.FirstOrDefault(w => w.Id == id);
            if (welcomeText != null)
                _context.WelcomeTexts.Remove(welcomeText);
        }

        public void PutWelcomeText(WelcomeText welcomeText)
        {
            if(welcomeText != null)
            _context.Entry(welcomeText).State = EntityState.Modified;
        }
    }
}