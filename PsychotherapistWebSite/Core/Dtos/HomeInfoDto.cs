using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PsychotherapistWebSite.Core.Models;

namespace PsychotherapistWebSite.Core.Dtos
{
    public class HomeInfoDto
    {
        public string PersonName { get; set; }

        public string PersonTitle { get; set; }

        public string Phone { get; set; }

        public AdressDto Adress { get; set; }

        public string Mail { get; set; }

        public string FaceBookUrl { get; set; }

        public string YouTubeUrl { get; set; }

        public string TweeterUrl { get; set; }

        public string AboutMe { get; set; }
    }
}