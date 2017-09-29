using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Models;

namespace PsychotherapistWebSite.Core.ViewModels
{
    public class SlideViewModel
    {
        public Slide Slide { get; set; }
        public IEnumerable<Motto> Mottoes { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public string ActionType { get; internal set; }
    }
}