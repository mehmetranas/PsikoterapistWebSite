
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PsychotherapistWebSite.Core.Dtos
{
    public class AdressDto
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
    }
}