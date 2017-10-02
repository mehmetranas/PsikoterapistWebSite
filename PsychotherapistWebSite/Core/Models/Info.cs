using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PsychotherapistWebSite.Core.Models
{
    public class Info
    {
        public int Id { get; set; }
        [Display(Name = "İsim")]
        [Required]
        public string PersonName { get; set; }
        [Display(Name = "Ünvan")]
        public string PersonTitle { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Adress")]
        public Adress Adress { get; set; }
        [Display(Name = "Facebook Adresiniz")]
        public string FaceBookUrl { get; set; }
        [Display(Name = "Youtube Adresiniz")]
        public string YouTubeUrl { get; set; }
        [Display(Name = "Tweeter Adresiniz")]
        public string TweeterUrl { get; set; }
        [Display(Name = "Hakkımda Yazısı")]
        [Required]
        public string AboutMe { get; set; }
    }
}