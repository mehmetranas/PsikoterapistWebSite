using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System;
using PsychotherapistWebSite.Core.Models;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class SlideRepository : ISlideRepsitory
    {
        private readonly ApplicationDbContext _context;

        public SlideRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Slide slide)
        {
            if (slide != null)
                _context.Slides.Add(slide);
        }

        public void Delete(int id)
        {
            var slide = _context.Slides.SingleOrDefault(s => s.Id == id);
            if(slide!=null)
            _context.Slides.Remove(slide);
        }

        public Slide GetSlide(int id)
        {
            return _context.Slides
                .Include(s => s.Motto)
                .Include(s => s.Image)
                .SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<Slide> GetSlides()
        {
            return _context.Slides
                .Include(s => s.Motto)
                .Include(s => s.Image)
                .ToList();
        }
    }
}