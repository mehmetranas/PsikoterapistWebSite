using PsychotherapistWebSite.Models;
using System.Collections.Generic;
using PsychotherapistWebSite.Core.Models;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IImageRepository
    {
        IEnumerable<Image> GetImages();
        void Delete(int id);
        Image GetImage(int? id);
        void Add(Image image);
    }
}