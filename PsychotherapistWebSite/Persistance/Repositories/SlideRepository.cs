using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;
using System.Collections.Generic;
using System.Linq;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class SlideRepository : ISlideRepsitory
    {
        private readonly ApplicationDbContext _context;

        public SlideRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Slide> GetSlides()
        {
            return _context.Slides.ToList();
        }
    }
}