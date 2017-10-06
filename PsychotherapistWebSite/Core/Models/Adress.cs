using System.ComponentModel.DataAnnotations;

namespace PsychotherapistWebSite.Core.Models
{
    public class Adress
    {
        public int Id { get; set; }
        [Display(Name = "Adress Adı")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Mahalle")]
        [Required]
        public string Place { get; set; }
        [Display(Name = "Cadde/Sokak")]
        public string Street { get; set; }
        [Display(Name = "Numara")]
        public string Number { get; set; }
        [Display(Name = "Semt")]
        [Required]
        public string Town { get; set; }
        [Display(Name = "Şehir")]
        [Required]
        public string City { get; set; }
    }
}