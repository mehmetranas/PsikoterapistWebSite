using System.ComponentModel.DataAnnotations;

namespace PsychotherapistWebSite.Core.Models
{
    public class WelcomeText
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [Required]
        [StringLength(600), Display(Name = "İçerik")]
        public string Content { get; set; }

    }
}