using System.ComponentModel.DataAnnotations;

namespace PsychotherapistWebSite.Core.Models
{
    public class WelcomeText
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(210)]
        public string Content { get; set; }

        public bool IsActive { get; set; }

    }
}