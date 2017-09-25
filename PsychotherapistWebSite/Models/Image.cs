using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PsychotherapistWebSite.Models
{
    public class Image
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        [Display(Name = "Resim Adı")]
        public string Name { get; set; }
        public string Url { get; set; }

    }
}