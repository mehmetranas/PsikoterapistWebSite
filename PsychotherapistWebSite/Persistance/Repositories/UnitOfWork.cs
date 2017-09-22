using System;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IServiceRepository Service { get; }
        public ISlideRepsitory Slide { get; }
        public IMottoRepository Motto { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Service = new ServiceRepository(_context);
            Slide = new SlideRepository(_context);
            Motto = new MottoRepository(_context);
        }

        public void Complete()
        {
           _context.SaveChanges();
        }
    }
}