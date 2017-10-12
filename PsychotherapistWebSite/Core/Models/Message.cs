using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PsychotherapistWebSite.Core.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Geçersiz Mail Adresi")]
        public string Mail { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Context { get; set; }

        public bool IsRead { get; set; }

    }
}