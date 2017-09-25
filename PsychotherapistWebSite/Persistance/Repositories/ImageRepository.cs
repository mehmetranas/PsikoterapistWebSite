using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PsychotherapistWebSite.Persistance.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly ApplicationDbContext _context;

        public ImageRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public void Add(Image image)
        {
            if(image != null)
            _context.Images.Add(image);

        }

        public void Delete(int id)
        {
            var image = _context.Images.SingleOrDefault(i => i.Id == id);

            string path = HttpContext.Current.Server.MapPath("~/Images/Slide/" + image.Url);
            DeleteFromServer(path);

            _context.Images.Remove(image);
            
        }

        public Image GetImage(int? id)
        {
            return _context.Images.Find(id);
        }

        private void DeleteFromServer(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

        }

        public IEnumerable<Image> GetImages()
        {
            var images = _context.Images.ToList();
            return images;
        }
    }
}