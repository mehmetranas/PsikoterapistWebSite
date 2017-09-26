using System.ComponentModel.DataAnnotations;

namespace PsychotherapistWebSite.Core.Models
{
    public class Motto
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Söz Başlığı")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Söz İçeriği")]
        [StringLength(250)]
        public string Text { get; set; }
        [Required]
        [Display(Name = "Sözü Söyleyen")]
        public string Teller { get; set; }
    }
}