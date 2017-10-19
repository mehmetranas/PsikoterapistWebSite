using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PsychotherapistWebSite.Core.Models
{
    public class Messages
    {
        public int  Id { get; set; }

        [Required]
        [Display(Name = "İsim")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Geçersiz Mail")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Mesaj")]
        public string MessageText { get; set; }

        public bool IsRead { get; set; }

        public DateTime DateTime => DateTime.Now;

        public void Read()
        {
            IsRead = true;
        }
    }
}