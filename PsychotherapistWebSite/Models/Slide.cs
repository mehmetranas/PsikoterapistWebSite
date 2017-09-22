﻿using System;
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
        public Image Image { get; set; }
        [Display(Name = "Özlü Söz")]
        public Motto Motto { get; set; }
    }
}