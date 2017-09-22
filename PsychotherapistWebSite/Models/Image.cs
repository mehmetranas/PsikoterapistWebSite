using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PsychotherapistWebSite.Models
{
    public class Image
    {
        [Microsoft.Build.Framework.Required]
        public int Id { get; set; }
        [Microsoft.Build.Framework.Required]
        [StringLength(80)]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }

    }
}