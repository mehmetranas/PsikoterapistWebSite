using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PsychotherapistWebSite.Core.Models
{
    public class Info
    {
        public Info()
        {
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }

        public ICollection<Image> Images { get; set; }

        [Display(Name = "İsim")]
        [Required]
        public string PersonName { get; set; }
        [Display(Name = "Ünvan")]
        public string PersonTitle { get; set; }

        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        public int AdressId { get; set; }

        [Display(Name = "Adress")]
        public Adress Adress { get; set; }

        [Display(Name = "Mail")]
        [EmailAddress]
        public string Mail { get; set; }

        [Display(Name = "Facebook Adresiniz")]
        public string FaceBookUrl { get; set; }

        [Display(Name = "Youtube Adresiniz")]
        public string YouTubeUrl { get; set; }

        [Display(Name = "Tweeter Adresiniz")]
        public string TweeterUrl { get; set; }

        [Display(Name = "Hakkımda Yazısı")]
        [Required]
        public string AboutMe { get; set; }

        public string TruncateContent => Helper.Helper.TruncateContent(AboutMe, 220);

    }
}