using System.ComponentModel.DataAnnotations;

namespace PsychotherapistWebSite.Core.Models
{
    public class Slide
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public int MottoId { get; set; }
        [Display(Name = "Resim")]
        public Image Image { get; set; }
        [Display(Name = "Özlü Söz")]
        public Motto Motto { get; set; }
    }
}