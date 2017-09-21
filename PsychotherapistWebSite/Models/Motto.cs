using System.ComponentModel.DataAnnotations;

namespace PsychotherapistWebSite.Models
{
    public class Motto
    {
        public int Id { get; set; }
        [Microsoft.Build.Framework.Required]
        [Display(Name = "Başlık")]
        public string Title { get; set; }
        [Microsoft.Build.Framework.Required]
        [Display(Name = "İçerik")]
        public string Text { get; set; }
        [Microsoft.Build.Framework.Required]
        [Display(Name = "Söyleyen")]
        public string Teller { get; set; }
    }
}