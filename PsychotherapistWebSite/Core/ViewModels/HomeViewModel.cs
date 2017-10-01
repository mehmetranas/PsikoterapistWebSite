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
        public ServiceViewModel[] Services { get; set; }
        public ServiceViewModel Service1 => Services.Length > 0 ? Services[0] : null;
        public ServiceViewModel Service2 => Services.Length > 0 ? Services[1] : null;
        public ServiceViewModel Service3 => Services.Length > 0 ? Services[2] : null;
        public WelcomeText WelcomeText { get; set; }
        public IEnumerable<FaqViewModel> FaqViewModels { get; set; }
        public IEnumerable<Slide> Slides { get; set; }
    }
}