using PsychotherapistWebSite.Models;
using System.Collections.Generic;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface ISlideRepsitory
    {
        IEnumerable<Slide> GetSlides();
        Slide GetSlide(int id);
        void Delete(int id);
        void Add(Slide slide);
    }
}