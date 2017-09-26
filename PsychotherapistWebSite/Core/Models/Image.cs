using System.ComponentModel.DataAnnotations;

namespace PsychotherapistWebSite.Core.Models
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