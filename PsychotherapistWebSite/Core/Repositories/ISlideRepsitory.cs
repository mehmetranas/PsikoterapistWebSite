using PsychotherapistWebSite.Models;
using System.Collections.Generic;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface ISlideRepsitory
    {
        IEnumerable<Slide> GetSlides();
    }
}