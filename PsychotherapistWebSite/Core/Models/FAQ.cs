using System.ComponentModel.DataAnnotations;

namespace PsychotherapistWebSite.Core.Models
{
    public class Faq
    {
        public int Id { get; set; }
        [Microsoft.Build.Framework.Required, Display(Name = "Soru")]
        public string Title { get; set; }
        [Microsoft.Build.Framework.Required, Display(Name = "Cevap")]
        public string Text { get; set; }

        public bool IsDisplayOnHomePage { get; set; }
    }
}