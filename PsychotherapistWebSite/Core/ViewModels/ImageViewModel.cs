using PsychotherapistWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PsychotherapistWebSite.Core.ViewModels
{
    public class ImageViewModel
    {
        public Image Image { get; set; }
        public HttpPostedFileBase File { get; set; }    
    }
}