using PsychotherapistWebSite.Core.Models;
using System.Collections.Generic;

namespace PsychotherapistWebSite.Core.ViewModels
{
    public class InfoViewModel
    {
        
        public Info Info { get; set; }
        public IEnumerable<Adress> Adresses { get; set; }
    }
}