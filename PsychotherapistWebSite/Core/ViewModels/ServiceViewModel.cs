using PsychotherapistWebSite.Core.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PsychotherapistWebSite.Core.ViewModels
{
    public class ServiceViewModel
    {
       public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Alan Adı")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Açıklama")]
        [StringLength(1000)]
        public string Content { get; set; }

        public Image[] Images { get; set; }

        public Image Image1 => Images.Length > 0 ? Images[0] : null;

        public Image Image2 => Images.Length > 1 ? Images[1] : null;

        public string TruncateContent => Helper.Helper.TruncateContent(Content, 35);

        public IEnumerable<Image> AllImages { get; set; }

    }
}