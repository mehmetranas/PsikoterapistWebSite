using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PsychotherapistWebSite.Core.Models;
using PsychotherapistWebSite.Models;

namespace PsychotherapistWebSite.Core.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Slide> Slides { get; set; }
    }
}