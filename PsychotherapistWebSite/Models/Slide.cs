using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PsychotherapistWebSite.Models
{
    public class Slide
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Resim Başlığı")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Resim Yolu")]
        public string Url { get; set; }
        [Display(Name = "Özlü Söz")]
        public Motto Motto { get; set; }
    }
}