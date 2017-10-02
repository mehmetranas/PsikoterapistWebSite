using PsychotherapistWebSite.Core.Models;
using System.Web;

namespace PsychotherapistWebSite.Core.ViewModels
{
    public class ImageViewModel
    {
        public Image Image { get; set; }
        public HttpPostedFileBase File { get; set; }    

    }
}