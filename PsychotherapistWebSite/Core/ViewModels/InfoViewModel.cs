using System;
using PsychotherapistWebSite.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace PsychotherapistWebSite.Core.ViewModels
{
    public class InfoViewModel
    {

      
        public Info Info { get; set; }

        public IEnumerable<Adress> Adresses { get; set; }

        public Image[] Images { get; set; }


        public Image Image1 => Images.Length > 0 ? Images[0] : null;

        public Image Image2 => Images.Length > 1 ? Images[1] : null;

        public IEnumerable<Image> AllImages { get; set; }
    }
}