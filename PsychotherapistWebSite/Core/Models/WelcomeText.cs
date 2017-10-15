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

        [Required]
        [StringLength(35), Display(Name = "Çalışma Zaman Aralığı")]
        public string DaysHour { get; set; }

        [Required]
        [StringLength(35), Display(Name = "Tatil Aralığı Dipnot")]
        public string NoteForClosedDay { get; set; }
    }
}